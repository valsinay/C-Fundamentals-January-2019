﻿
namespace _04.OnlineRadio.Exceptions
{
    using System;

    public class InvalidSongException : Exception
    {
        public override string Message => "Invalid song.";
    }
}
