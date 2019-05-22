﻿using System;
using System.Threading.Tasks;

namespace Project.Repositories
{
    public interface IXamarinEssentialsRepository
    {
        Task OpenBrowser(string uri);
        Task ShareUrl(string url);
    }
}