﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler
{
    public class Usuario
    {
        public string usuario { get; set; }
        public string password { get; set; }


        public Usuario(string usuario, string password) { 
            this.usuario = usuario; 
            this.password = password;
        }
    }
}
