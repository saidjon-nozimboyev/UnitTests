﻿using System.Text.RegularExpressions;

namespace Service.Test.Helpers;

public class EmailHelper
{
    public bool EmailIsValid(string email)
        => Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
}
