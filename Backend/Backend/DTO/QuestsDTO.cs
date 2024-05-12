using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DTO
{
    public class QuestsDTO
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Posted { get; set; }

        public int UserId { get; set; }

        public int AnswersId { get; set; }
    }
}
