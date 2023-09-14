﻿namespace EmployeeManagement.Models
{
    interface ILogger
    {
        void WriteEvent(string eventMessage);
        void WriteError(string errorMessage);
    }
}
