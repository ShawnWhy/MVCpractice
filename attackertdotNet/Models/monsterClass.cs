using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace attackertdotNet.Models
{
    public class monsterClass
    {
        public int Id { get; set; }
        public string MonsterHTML { get; set; }

        public string Name { get; set; }

        public string Creator { get; set; }
        public bool IsDestroyed { get; set; }
    }
}