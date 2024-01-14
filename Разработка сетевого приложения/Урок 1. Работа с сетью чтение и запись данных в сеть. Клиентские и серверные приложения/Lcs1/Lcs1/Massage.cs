﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Lcs1
{
    internal class Massage
    {
        public string Name { get; set; }

        public string Text { get; set; }

        public DateTime Stime { get; set; }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        public static Massage? FromJson(string somemassage)
        {
            return JsonSerializer.Deserialize<Massage>(somemassage);
        }

        public Massage(string nikname, string text)
        {
            this.Name = nikname;
            this.Text = text;
            this.Stime = DateTime.Now;
        }

        public Massage() { }

        public override string ToString()
        {
            return $"Получено сообщение от {Name} ({Stime.ToShortTimeString()}): \n {Text}";
        }
    }
}
