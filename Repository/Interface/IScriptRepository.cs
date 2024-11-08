﻿using CGenius.Models;

namespace CGenius.Repository.Interface
{
    public interface IScriptRepository
    {
        Task<IEnumerable<Script>> GetScripts();
        Task<Script> GetScript(int idScript);
        Task<Script> AddScript(Script script);
        Task<Script> UpdateScript(Script script);
        void DeleteScript(int idScript);
    }
}