﻿

using Models;
using DAL;
using System.Data;

namespace BLL
{
    public class EleitorBLL
    {
        public void Inserir(Eleitor _eleitor)
        {
            if (_eleitor.Nome.Length <= 2) 
                throw new Exception("O nome do eleitor dever ter mais de 2 caractre ");

            EleitorDAL eleitorDAL = new EleitorDAL();
            eleitorDAL.Inserir(_eleitor);
        }
        
        public void Excluir(Eleitor _eleitor)
        {
            EleitorDAL _eleitorDAL = new EleitorDAL();
            _eleitorDAL.Excluir(_eleitor);
        }

        public void Alterar(Eleitor _eleitor)
        {
            if (_eleitor.Nome.Length <= 2)
                throw new Exception("O nome do eleitor dever ter mais de 2 caractre ");

            EleitorDAL _eleitorDAL = new EleitorDAL();
            _eleitorDAL.Alterar(_eleitor);
        }
         
        public DataTable Buscar(string _titulo)
        {

            EleitorDAL _eleitorDAL = new EleitorDAL();
            return  _eleitorDAL.BuscarPorTitulo(_titulo);
        }

    }
}
