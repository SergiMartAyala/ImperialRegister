using System;
using System.Collections.Generic;

namespace ImperialRegister
{
    public class ImperialRegisterDeclaration
    {
        public Information[] InformationDetails { get; set; }
    }
    public class Information
    {
        public string Name { get; set; }

        public string Planet { get; set; }
    }
}
