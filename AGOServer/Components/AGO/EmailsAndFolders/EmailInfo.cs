﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AGOServer
{
    /// <summary>
    /// Email Object in Content Server
    /// </summary>
    public class EmailInfo
    {
        private long nodeID;
        private long parentNodeID;
        private string name;
        private string iconUri;
        private bool permSeeContents;

        private string emailSubject;
        private string emailTo;
        private string emailCC;
        private string emailFrom;
        private DateTime? sentDate;
        private DateTime? receivedDate;
        private int hasAttachments;

        private long fileSize;

        private string conversationId;

        private string summary;

        private long clientLocalEmailID;

        public long NodeID { get => nodeID; set => nodeID = value; }
        public string Name { get => name; set => name = value; }
        public bool PermSeeContents { get => permSeeContents; set => permSeeContents = value; }
        public string IconUri { get => iconUri; set => iconUri = value; }
        public long ParentNodeID { get => parentNodeID; set => parentNodeID = value; }
        public string EmailSubject { get => emailSubject; set => emailSubject = HttpUtility.HtmlDecode(value); }
        public string EmailTo { get => emailTo; set => emailTo = value; }
        public string EmailCC { get => emailCC; set => emailCC = value; }
        public string EmailFrom { get => emailFrom; set => emailFrom = value; }
        public DateTime? SentDate { get => sentDate; set => sentDate = value; }
        public DateTime? ReceivedDate { get => receivedDate; set => receivedDate = value; }
        public string ConversationId { get => conversationId; set => conversationId = value; }
        public int HasAttachments { get => hasAttachments; set => hasAttachments = value; }
        public long FileSize { get => fileSize; set => fileSize = value; }
        public string Summary { get => summary; set => summary = value; }
        public long ClientLocalEmailID { get => clientLocalEmailID; set => clientLocalEmailID = value; }

        private List<AttachmentInfo> attachments = new List<AttachmentInfo>();

        public List<AttachmentInfo> Attachments { get => attachments; set => attachments = value; }
    }
}