﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tin_version_2.Commands;

namespace tin_version_2.Commands
{
    public class Help : Command
    {
        public Help(string name) : base(name)
        {
        }
        public override string Execute(string[] args)
        {

            string h_util = "welocome to the tin os help tool the only command is the help gui launch is coming soon new command is file command";
            return h_util;
        }
    }
}
