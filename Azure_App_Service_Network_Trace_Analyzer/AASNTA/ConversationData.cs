﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
using System;
using System.Collections;


namespace AASNTA
{
    //
    // Written by the Microsoft CSS SQL Networking Team
    //
    // Data that is stored per conversation
    // Helper methods for getting formatted data
    // Helper methods for dumping conversations for debugging purposes
    //

    public class ConversationData              //              - constructed in GetIPV4Conversation and GetIPV6Conversation
    {
        // Collections
        public ArrayList frames = new ArrayList();  //   - frame added in ParseIPV4Frame and ParseIPV6Frame
        public ArrayList packets = new ArrayList(); //   - packet added in CreatingPacketsFromFrames
        // Packet Monitor Stats
        public bool hasPktmonDroppedEvent = false;     // - set in ConversationData.AddFrame
        public uint pktmonDropReason = 0;              // - set in ConversationData.AddFrame
        public long pktmonMaxDelay = 0;                // - set in OutputText.DisplayDelayedPktmonEvents
        // Link Layer Properties - Ethernet and WiFi
        public ulong sourceMAC = 0;     // six bytes     - set in ParseEthernetFrame
        public ulong destMAC = 0;       // six bytes     - set in ParseEthernetFrame
        // IP Properties - IPV4 and IPV6
        public bool isIPV6 = false;     //               - set in GetIPV6Conversation; GetIPV4Conversation leaves at default
        public uint sourceIP = 0;       // IPV4          - set in GetIPV4Conversation
        public ulong sourceIPHi = 0;    // IPV6          - set in GetIPV6Conversation
        public ulong sourceIPLo = 0;    // IPV6          - set in GetIPV6Conversation
        public uint destIP = 0;         // IPV4          - set in GetIPV4Conversation
        public ulong destIPHi = 0;      // IPV6          - set in GetIPV6Conversation
        public ulong destIPLo = 0;      // IPV6          - set in GetIPV6Conversation
        public uint TTLSumIn = 0;       // IPV4/IPV6     - set in GetIPV4/6Conversation - Accumulates the first 10 values - to get the average # hops and compare against the minimum
        public uint TTLCountIn = 0;     // IPV4/IPV6     - set in GetIPV4/6Conversation - Counts the first 10 values
        public byte minTTLHopsIn = 255; // IPV4/IPV6     - set in GetIPV4/6Conversation
        public uint TTLSumOut = 0;      // IPV4/IPV6     - set in GetIPV4/6Conversation - Accumulates the first 10 values - to get the average # hops and compare against the minimum
        public uint TTLCountOut = 0;    // IPV4/IPV6     - set in GetIPV4/6Conversation - Counts the first 10 values
        public byte minTTLHopsOut = 255;// IPV4/IPV6     - set in GetIPV4/6Conversation
        // Transport Properties - TCP and UDP
        public byte nextProtocol = 0;   //               - set in ParseIPV4Frame and ParseIPV6Frame (6 = TCP or 17 = UDP)
        public bool isUDP = false;      //               - set in ParseUDPFrame; ParseTCPFrame leaves it at default
        public ushort sourcePort = 0;   //               - set in GetIPV4Conversation and GetIPV6Conversation
        public ushort destPort = 0;     //               - set in GetIPV4Conversation and GetIPV6Conversation
        // Conversation statistics
        public ulong totalBytes = 0;    //               - set in ParseTCPFrame
        public ulong totalPayloadBytes = 0;         //   - set in ParseTCPFrame
        public long startTick = 0;      //               - set in ParseEthernetFrame
        public long endTick = 0;        //               - set in ParseEthernetFrame
        public int ackCount = 0;        //               - accumulated in ParseTCPFrame - can be in combination with other flags
        public int pushCount = 0;       //               - accumulated in ParseTCPFrame - can be in combination with other flags
        public int resetCount = 0;      //               - accumulated in ParseTCPFrame - can be in combination with other flags
        public int synCount = 0;        //               - accumulated in ParseTCPFrame - can be in combination with other flags
        public int finCount = 0;        //               - accumulated in ParseTCPFrame - can be in combination with other flags
        public bool hasClientFin = false;           //   - set in ParseTCPFrame
        public bool hasServerFin = false;           //   - set in ParseTCPFrame
        public bool hasServerFinFirst = false;      //   - set in ParseTCPFrame - used to determine whether the server closed the conversation
        public uint missingPackets = 0;
        public uint duplicateClientPackets = 0;     //   - accumulated in ParseIPV4Frame - unfortunately IPV6 does not have a packet identifier ****
        public uint duplicateServerPackets = 0;     //   - accumulated in ParseIPV4Frame - unfortunately IPV6 does not have a packet identifier ****
        public uint rawRetransmits = 0;             //   - accumulated in FindRetransmits
        public uint sigRetransmits = 0;             //   - accumulated in FindRetransmits
        public ushort maxRetransmitCount = 0;       //   - accumulated in FindRetransmits
        public uint sourceFrames = 0;               //   - accumulated in ParseEthernetFrame
        public uint destFrames = 0;                 //   - accumulated in ParseEthernetFrame
        public uint keepAliveCount = 0;             //   - accumulated in ParseTCPFrame
        public ushort maxKeepAliveRetransmits = 0;  //   - accoumulated in FindKeepAliveRetransmits
        public uint truncatedFrameLength = 0;       //         
        public uint truncationErrorCount = 0;       //         
        public int maxPayloadSize = 0;              //   - accumulated in ParseTCPFrame
        public bool maxPayloadLimit = false;        //   - accumulated in ParseTCPFrame
        // SQL-specific values
        public int tdsFrames = 0;                   //   - set in ProcessTDS
        public bool hasTDS = false;                 //   - set in ProcessTDS
        public bool hasTDS8 = false;                //   - set in ProcessTDS
        public bool isSQL = false;                  //   - set in ProcessTDS
        public bool isEncrypted = false;            //   - set in GetServerPreloginInfo
        public bool isEncRequired = false;          //   - set in 
        public bool isMARSEnabled = false;          //   - set in ProcessTDS - in PreLogin packet
        public bool hasPrelogin = false;            //   - set in ProcessTDS
        public bool hasPreloginResponse = false;    //   - set in ProcessTDS
        public bool hasClientSSL = false;           //   - set in ProcessTDS
        public bool hasServerSSL = false;           //   - set in ProcessTDS
        public bool hasKeyExchange = false;         //   - set in ProcessTDS
        public bool hasCipherExchange = false;      //   - set in ProcessTDS
        public bool hasApplicationData = false;     //   - set in ProcessTDS   - this is the encrypted logon payload token
        public bool hasLogin7 = false;              //   - set in ProcessTDS   - this is the unencrypted login payload token - we should not see this unless SSL/TLS is disabled - very unsecure
        public bool hasSSPI = false;                //   - set in ProcessTDS
        public bool hasNTLMChallenge = false;       //   - set in ProcessTDS
        public bool hasNTLMResponse = false;        //   - set in ProcessTDS
        public bool hasNullNTLMCreds = false;       //   - set in ProcessTDS
        public bool hasIntegratedSecurity = false;  //   - set in ProcessTDS
        public bool hasPostLoginResponse = false;   //   - set in ProcessTDS   - this contains the ENVCHANGE token - login was a success
        public bool hasDiffieHellman = false;       //   - set in ProcessTDS
        public int smpSynCount = 0;                 //   - accumulated in ParseTCPFrame
        public int smpAckCount = 0;                 //   - accumulated in ParseTCPFrame
        public int smpFinCount = 0;                 //   - accumulated in ParseTCPFrame
        public int smpDataCount = 0;                //   - accumulated in ParseTCPFrame
        public int smpMaxSession = -1;              //   - accumulated in ParseTCPFrame
        public int SPID = 0;
        public string clientVersion = null;         //   - set in GetClientPreloginInfo
        public string serverVersion = null;         //   - set in ProcessTDS
        public uint tdsVersionServer = 0;           //   - set in ProcessTDS
        public uint tdsVersionClient = 0;           //   - set in ProcessTDS
        public string tlsVersionClient = null;      //   - set in ProcessTDS
        public string tlsVersionServer = null;      //   - set in ProcessTDS
        public bool hasLowTLSVersion = false;       //   - set in ProcessTDS
        public string databaseName = null;          //   - set in ProcessTDS
        public string serverName = null;            //   - set in ProcessTDS
        public uint processID = 0;
        public uint threadID = 0;                   //   - set in GetClientPreloginInfo
        // Login Error and Delay Stats
        public long synTime = 0;                    //
        public long ackSynTime = 0;                 //
        public long PreLoginTime = 0;               //   - set in TDS Parser - so we can time the PreLogin packet delay
        public long PreLoginResponseTime = 0;       //   - set in TDS Parser - so we can time the Prelogin packet response delay
        public long ClientHelloTime = 0;            //   - set in TDS Parser - so we can time the Client Hello packet delay
        public long ServerHelloTime = 0;            //   - set in TDS Parser - so we can time the Server Hello packet delay
        public long KeyExchangeTime = 0;            //   - set in TDS Parser - so we can time the Key Exchange packet delay
        public long CipherExchangeTime = 0;         //   - set in TDS Parser - so we can time the Cipher Exchange packet delay
        public long LoginTime = 0;                  //   - set in TDS Parser - so we can time the Login or Login7 packet delay
        public long SSPITime = 0;                   //   - set in TDS Parser - so we can time the SSPI packet delay
        public long NTLMChallengeTime = 0;          //   - set in TDS Parser - so we can time the NTLM Challenge packet delay
        public long NTLMResponseTime = 0;           //   - set in TDS Parser - so we can time the NTLM Response packet delay
        public long LoginAckTime = 0;               //   - set in TDS Parser - so we can time the LoginAck packet delay
        public long ErrorTime = 0;                  //   - set in TDS Parser - so we can time the Login Error packet delay
        public long FinTime = 0;                    //   - set in TCP Parser - so we can check whether LoginAck was sent after connection was closed
        public long ResetTime = 0;                  //   - set in TCP Parser - so we can check whether LoginAck was sent after connection was closed
        public long AttentionTime = 0;              //   - set in TDS Parser - so we can identify command timeouts
        public long smpFinTime = 0;                 //   - accumulated in ParseTCPFrame
        public uint Error = 0;
        public string ErrorMsg = "";
        public uint ErrorState = 0;
        public bool hasRedirectedConnection = false;
        public uint RedirectPort = 0;
        public string RedirectServer = "";
        public string PipeAdminName = "";              // - set in TCP Parser
        public ArrayList PipeNames = new ArrayList();  // - set in TCP Parser
        public string tlsVersionUsed = null;      //   - set in ProcessTDS

        public void AddFrame(FrameData f, NetworkTrace t)  // replaces adding the frame directly to the frames ArrayList
        {
            //
            // Rubrick:
            //
            // If the frame is not a pktmon frame, add the the frames ArrayData and exit. This will be the norm for almost all traces analyzed.
            // If the frame is a pktmon frame, find the previous instance of this frame (go backwards for efficiency).
            //    If no previous instance, create the pktmonComponentFrames ArrayList and add the frame to that and add the frame to the ArrayList and exit.
            //    If there is a previous frame, add the frame to the pktmonComponentFrames ArrayList of that frame and exit.
            //

            if (f.pktmon == null)
            {
                frames.Add(f);
                t.frames.Add(f);
            }
            else
            {
                // search and add - use the limit of 20 frames. For a single conversation, it can't be out of sequence that much
                if (f.pktmon.eventID == 170)  // drop packet event
                {
                    this.hasPktmonDroppedEvent = true;
                    this.pktmonDropReason = f.pktmon.DropReason;
                }
                const int BACK_COUNT_LIMIT = 20;
                int backCount = 0;
                for (int i = this.frames.Count - 1; i >= 0; i--)
                {
                    FrameData priorFrame = (FrameData)frames[i];
                    backCount++;
                    if (priorFrame.pktmon.PktGroupId == f.pktmon.PktGroupId)
                    {
                        priorFrame.pktmonComponentFrames.Add(f);  // found withing BACK_COUNT_LIMIT frames
                        return;
                    }
                    if (backCount >= BACK_COUNT_LIMIT) break;
                }
                // not found within BACK_COUNT_LIMIT frames, so assume it's the first
                f.pktmonComponentFrames = new ArrayList();
                f.pktmonComponentFrames.Add(f);  // make sure the frame is first in the list, so we don't have to treat it differently when performing pktmon analyses
                frames.Add(f);
                t.frames.Add(f);
            }
        }
        public bool hasLateLoginAck  // added Dec 5, 2016
        {
            get
            {
                if (LoginAckTime == 0)
                {
                    return false;
                }
                else
                {
                    if (FinTime > 0 && LoginAckTime > FinTime) return true;
                    if (ResetTime > 0 && LoginAckTime > ResetTime) return true;
                    return false;
                }
            }
        }

        public bool hasLoginFailure     // TODO this needs work one of the OR-ed flags below is TRUE and it shouldn't be...
        {
            get
            {
                if (hasLateLoginAck || ErrorMsg != "") return true; // added Dec 5, 2016
                if (isEncrypted)
                {
                    if ((hasApplicationData == false) &&
                        ((resetCount > 0) || (finCount > 0)) &&
                        ((synCount > 0) || hasPrelogin || hasPreloginResponse || hasClientSSL || hasServerSSL ||
                          hasKeyExchange || hasCipherExchange || hasNTLMChallenge || hasNTLMResponse))
                    {
                        return true;
                    }
                }
                else
                {
                    if (hasApplicationData == true && synCount == 0 && hasPrelogin == false && hasPreloginResponse == false &&
                        hasClientSSL == false && hasServerSSL == false && hasKeyExchange == false && hasCipherExchange == false &&
                        hasNTLMChallenge == false && hasNTLMResponse == false && frames.Count > (4 + 2 * keepAliveCount + rawRetransmits))
                    {
                        return false;
                    }
                    if ((hasPostLoginResponse == false) &&
                          ((resetCount > 0) || (finCount > 0)) &&
                          ((synCount > 0) || hasPrelogin || hasPreloginResponse || hasClientSSL || hasServerSSL ||
                            hasKeyExchange || hasCipherExchange || hasNTLMChallenge || hasNTLMResponse || hasApplicationData))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        //
        // Did this conversation even manage to contact the server, let alone login.
        // Needs at least one SYN packet to show the start of the conversation.
        // Cannot have any PUSH flags for application payload.
        // ACK + RESET + FIN are optionally allowed
        //
        public bool hasSynFailure
        {
            get
            {
                return (synCount > 0 && pushCount ==0);
            }
        }

        public long LoginDelay(string step, long firstFrameTick)   // times are in ticks, if prior packet time is unknown - timed to start of trace
        {
            long notPresent = (long)(-1 * utility.TICKS_PER_MILLISECOND);  // this value means a blank in the report instead of a 0.
            long priorTick = firstFrameTick;
            if (synTime != 0) priorTick = synTime;
            if (step == "AS") return ackSynTime == 0 ? notPresent : ackSynTime - priorTick;
            if (ackSynTime != 0) priorTick = ackSynTime;
            if (step == "PL") return PreLoginTime == 0 ? notPresent : PreLoginTime - priorTick;
            if (PreLoginTime != 0) priorTick = PreLoginTime;
            if (step == "PR") return PreLoginResponseTime == 0 ? notPresent : PreLoginResponseTime - priorTick;
            if (PreLoginResponseTime != 0) priorTick = PreLoginResponseTime;
            if (step == "CH") return ClientHelloTime == 0 ? notPresent : ClientHelloTime - priorTick;
            if (ClientHelloTime != 0) priorTick = ClientHelloTime;
            if (step == "SH") return ServerHelloTime == 0 ? notPresent : ServerHelloTime - priorTick;
            if (ServerHelloTime != 0) priorTick = ServerHelloTime;
            if (step == "KE") return KeyExchangeTime == 0 ? notPresent : KeyExchangeTime - priorTick;
            if (KeyExchangeTime != 0) priorTick = KeyExchangeTime;
            if (step == "CE") return CipherExchangeTime == 0 ? notPresent : CipherExchangeTime - priorTick;
            if (CipherExchangeTime != 0) priorTick = CipherExchangeTime;
            if (step == "AD") return LoginTime == 0 ? notPresent : LoginTime - priorTick;
            if (LoginTime != 0) priorTick = LoginTime;
            if (step == "SS") return SSPITime == 0 ? notPresent : SSPITime - priorTick;
            if (SSPITime != 0) priorTick = SSPITime;
            if (step == "NC") return NTLMChallengeTime == 0 ? notPresent : NTLMChallengeTime - priorTick;
            if (NTLMChallengeTime != 0) priorTick = NTLMChallengeTime;
            if (step == "NR") return NTLMResponseTime == 0 ? notPresent : NTLMResponseTime - priorTick;
            if (NTLMResponseTime != 0) priorTick = NTLMResponseTime;
            if (step == "LA") return LoginAckTime == 0 ? notPresent : LoginAckTime - priorTick;
            if (LoginAckTime != 0) priorTick = LoginAckTime;
            if (step == "ER") return ErrorTime == 0 ? notPresent : ErrorTime - priorTick;
            return notPresent;   // -1 means step not in the list above or step time is 0
        }

        public long LastPreloginTime()   // times are in ticks
        {
            if (ErrorTime > 0) return ErrorTime;
            if (LoginAckTime > 0) return LoginAckTime;
            if (NTLMResponseTime > 0) return NTLMResponseTime;
            if (NTLMChallengeTime > 0) return NTLMChallengeTime;
            if (SSPITime > 0) return SSPITime;
            if (CipherExchangeTime > 0) return CipherExchangeTime;
            if (KeyExchangeTime > 0) return KeyExchangeTime;
            if (ServerHelloTime > 0) return ServerHelloTime;
            if (ClientHelloTime > 0) return ClientHelloTime;
            if (PreLoginResponseTime > 0) return PreLoginResponseTime;
            if (PreLoginTime > 0) return PreLoginTime;
            return ackSynTime;
        }

        public string FriendlyTDSVersionServer  // these are SERVER return codes, not client codes, which are different
        {
            get
            {
                switch (tdsVersionServer)
                {
                    case 0:
                        {
                            return isSQL ? "Unknown" : "";
                        }
                    case 0x07000000:
                        {
                            return "7.0 (SQL 7.0)";
                        }
                    case 0x07010000:
                        {
                            return "7.1 (SQL 2000)";
                        }
                    case 0x71000001:
                        {
                            return "7.1 (SQL 2000 SP1)";
                        }
                    case 0x72090002:
                        {
                            return "7.2 (SQL 2005)";
                        }
                    case 0x730A0003:
                        {
                            return "7.3 (SQL 2008)";
                        }
                    case 0x730B0003:
                        {
                            return "7.3 (SQL 2008 R2)";
                        }
                    case 0x74000004:
                        {
                            return "7.4 (SQL 2012+)";
                        }
                    default:
                        {
                            return tdsVersionServer.ToString("X8");
                        }
                }
            }
        }

        public string FriendlyTDSVersionClient  // these are SERVER return codes, not client codes, which are different
        {
            get
            {
                switch (tdsVersionClient)
                {
                    case 0:
                        {
                            return isSQL ? "Unknown" : "";
                        }
                    case 0x00000070:
                        {
                            return "7.0 (SQL 7.0)";
                        }
                    case 0x00000071:
                        {
                            return "7.1 (SQL 2000)";
                        }
                    case 0x01000071:
                        {
                            return "7.1 (SQL 2000 SP1)";
                        }
                    case 0x02000972:
                        {
                            return "7.2 (SQL 2005)";
                        }
                    case 0x03000A73:
                        {
                            return "7.3 (SQL 2008)";
                        }
                    case 0x03000B73:
                        {
                            return "7.3 (SQL 2008 R2)";
                        }
                    case 0x04000074:
                        {
                            return "7.4 (SQL 2012+)";
                        }
                    default:
                        {
                            return tdsVersionServer.ToString("X8");
                        }
                }
            }
        }

        public string loginFlags
        {
            get
            {
                string s = (synCount > 0 ? "S " : "  ") +
                           (hasPrelogin ? "PL " : "   ") +
                           (hasPreloginResponse ? "PR " : "   ") +
                           (hasClientSSL ? "CH " : "   ") +
                           (hasServerSSL ? "SH " : "   ") +
                           (hasKeyExchange ? "KE " : "   ") +
                           (hasCipherExchange ? "CE " : "   ") +
                           (hasApplicationData ? "AD " : "   ") +
                           (hasNTLMChallenge ? "NC " : "   ") +
                           (hasNTLMResponse ? "NR " : "   ") +
                           (hasSSPI ? "SS " : "   ") +
                           (ErrorTime != 0 ? "ER" : "  ");

                return s;
            }
        }

        public string GetPacketList(int start, int length)
        {
            string s = "";
            for (int i = start; i < start + length; i++) s += ((FrameData)frames[i]).PacketTypeAndDirection + " ";
            return s.TrimEnd();
        }

        public string GetLastPacketList(int length)
        {
            if (length > frames.Count)
            {
                return GetPacketList(0, frames.Count);
            }
            else
            {
                return GetPacketList(frames.Count - length, length);
            }
        }

        public string GetFirstPacketList(int length)
        {
            if (length > frames.Count)
            {
                return GetPacketList(0, frames.Count);
            }
            else
            {
                return GetPacketList(0, length);
            }
        }

        public string ColumnHeader1()
        {
            string s = "";
            if (isIPV6)
            {
                s = "Source MAC   Dest MAC     Source IP Address                       SPort Destination IP Address                  DPort";
            }
            else
            {
                s = "Source MAC   Dest MAC     Source IP       SPort Destination IP  DPort";
            }
            if (isUDP)
            {
                return s + " Protocol StartTime              End Time               Duration (s) Frames   SFrames  DFrames";
            }
            else
            {
                return s +
                       " Protocol StartTime              " +
                       "End Time               Duration (s) Frames   SFrames  DFrames  ACK    PUSH   RESET  SYN FIN Missing Raw Retrans Sig Retrans SQL TDS Frames SPID";
            }
        }

        public string ColumnHeader2()
        {
            string s = "";

            if (isIPV6)
            {
                s = "------------ ------------ --------------------------------------- ----- --------------------------------------- -----";
            }
            else
            {
                s = "------------ ------------ --------------- ----- --------------- -----";
            }
            if (isUDP)
            {
                return s + " -------- ---------------------- ---------------------- ------------ -------- -------- --------";
            }
            else
            {
                return s +
                       " -------- ---------------------- " +
                       "---------------------- ------------ -------- -------- -------- ------ ------ ------ --- --- ------- ----------- ----------- --- ---------- -----";
            }
        }

        public string ColumnData()
        {
            if (isUDP)
            {
                return sourceMAC.ToString("X12") +
                       " " + destMAC.ToString("X12") +
                       (isIPV6 ? utility.FormatIPV6Address(sourceIPHi, sourceIPLo).PadLeft(40) : utility.FormatIPV4Address(sourceIP).PadLeft(16)) +
                       sourcePort.ToString().PadLeft(6) +
                       (isIPV6 ? utility.FormatIPV6Address(destIPHi, destIPLo).PadLeft(40) : utility.FormatIPV4Address(destIP).PadLeft(16)) +
                       destPort.ToString().PadLeft(6) +
                       (isUDP ? "      UDP" : "      TCP") +
                       " " + new DateTime(startTick).ToString(utility.DATE_FORMAT) +
                       " " + new DateTime(endTick).ToString(utility.DATE_FORMAT) +
                       ((double)(endTick - startTick) / 10000000).ToString("0.000000").PadLeft(13) +
                       frames.Count.ToString().PadLeft(9) +
                       sourceFrames.ToString().PadLeft(9) +
                       destFrames.ToString().PadLeft(9);
            }
            else
            {
                return sourceMAC.ToString("X12") +
                       " " + destMAC.ToString("X12") +
                       (isIPV6 ? utility.FormatIPV6Address(sourceIPHi, sourceIPLo).PadLeft(40) : utility.FormatIPV4Address(sourceIP).PadLeft(16)) +
                       sourcePort.ToString().PadLeft(6) +
                       (isIPV6 ? utility.FormatIPV6Address(destIPHi, destIPLo).PadLeft(40) : utility.FormatIPV4Address(destIP).PadLeft(16)) +
                       destPort.ToString().PadLeft(6) +
                       (isUDP ? "      UDP" : "      TCP") +
                       " " + new DateTime(startTick).ToString(utility.DATE_FORMAT) +
                       " " + new DateTime(endTick).ToString(utility.DATE_FORMAT) +
                       ((double)(endTick - startTick) / 10000000).ToString("0.000000").PadLeft(13) +
                       frames.Count.ToString().PadLeft(9) +
                       sourceFrames.ToString().PadLeft(9) +
                       destFrames.ToString().PadLeft(9) +
                       ackCount.ToString().PadLeft(7) +
                       pushCount.ToString().PadLeft(7) +
                       resetCount.ToString().PadLeft(7) +
                       synCount.ToString().PadLeft(4) +
                       finCount.ToString().PadLeft(4) +
                       missingPackets.ToString().PadLeft(8) +
                       rawRetransmits.ToString().PadLeft(12) +
                       sigRetransmits.ToString().PadLeft(12) +
                       (isSQL ? " YES" : "  No") +
                       tdsFrames.ToString().PadLeft(11) +
                       SPID.ToString().PadLeft(6);
            }
        }
    }
}