using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat.Base;

namespace Chat.Data;

    public class User : BaseModel
    {
        public string Role { get; set; }
    }
