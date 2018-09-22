using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DNC.ManageBoard.Models
{
    public class ToDoItem
    {
        public int ID { get; set; }

        [Required]
        public string Topic { get; set; }

        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        public DateTime DateTime { get; set; } = DateTime.UtcNow;

        public bool IsFinished { get; set; } = false;
    }
}
