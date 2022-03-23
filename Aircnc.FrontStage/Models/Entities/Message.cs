using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Aircnc.FrontStage.Models.Entities
{
    public partial class Message
    {
        [Key]
        public int MessageId { get; set; }
        public int SenderId { get; set; }
        public int RecipientId { get; set; }
        public string Text { get; set; }
        public DateTime SendTime { get; set; }

        public virtual User Recipient { get; set; }
        public virtual User Sender { get; set; }
    }
}
