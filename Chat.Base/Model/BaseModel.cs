using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Base;

public class BaseModel
{
    public int Id { get; set; }
    public string Email { get; set; }
        public string Password { get; set; }
    public bool isActive { get; set; }
}
