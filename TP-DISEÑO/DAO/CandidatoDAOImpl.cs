﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using TP_DISEÑO;
using TP_DISEÑO.DTO;

namespace TP_DISEÑO.DAO
{
    class CandidatoDAOImpl : ICandidatoDAO
    {
        public candidato GetCandidatoByDoc(int numDoc, string TipoDoc, CapitalHumanoEntities context)
        {
            candidato candidato = null;
            try
            {
                candidato = context.candidato.Where(c => c.numDoc == numDoc & c.TipoDoc == TipoDoc).FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return candidato;
        }

        public cuestionario GetUltimoCuestionarioActivo(candidato candidato)
        {

            cuestionario cuestionario = null;

            try
            {
                
                foreach (cuestionario oCuestionario in candidato.cuestionario)
                {
                    if(oCuestionario.Estado == "Activo")
                    {
                        cuestionario = oCuestionario;
                    }
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return cuestionario;

        }

    }

}
