﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DISEÑO.DAO
{
    interface ICompetenciaDAO
    {
        competencia GetCompetencia(int id, CapitalHumanoEntities context);
        competencia GetCompetenciaByNombre(string nombre, CapitalHumanoEntities context);
        List<string> GetAllCompetencias(CapitalHumanoEntities context);
    }
}
