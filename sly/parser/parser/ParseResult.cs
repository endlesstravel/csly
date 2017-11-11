﻿using System;
using System.Collections.Generic;
using System.Text;

namespace sly.parser
{
    public class ParseResult<IN,OUT>
    {

        public OUT Result { get; set; }

        public bool IsError { get; set; }

        public bool IsOk => !IsError;

        public List<ParseError> Errors { get; set; }

        public int EndingPosition { get; set; }

        public bool IsEnded { get; set; }
    }
}
