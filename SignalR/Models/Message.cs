using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreateTime { get; set; }
        [ForeignKey("Sender")]
        public int SenderId { get; set; }
        public CustomUser Sender { get; set; }
        [ForeignKey("Reciever")]
        public int RecieverId { get; set; }
        public CustomUser Reciever { get; set; }
    }
}
