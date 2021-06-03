﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro : Documento
    {

        /// <summary>
        /// Constructor por defecto. Asigna el primer paso del proceso (introducido).
        /// </summary>
        public Libro() : base() { }

        /// <summary>
        /// Constructor del documento. 
        /// </summary>
        /// <param name="titulo">Título a asignar.</param>
        /// <param name="autor">Autor a asignar.</param>
        /// <param name="anio">Año a asignar.</param>
        /// <param name="numeroPaginas">Número de páginas a asignar.</param>
        /// <param name="id">Id del documento.</param>
        /// <param name="barcode">Código de barras del documento.</param>
        /// <param name="estadoEncuadernacion">Estado de encuadernación.</param>
        public Libro(string titulo, string autor, short anio, short numeroPaginas, string id, int barcode, string notas,
                         Encuadernacion estadoEncuadernacion)
            : base(titulo, autor, anio, numeroPaginas, id, barcode, notas, estadoEncuadernacion) { }


        public static Libro GenerarLibro(
                                       string titulo,
                                       string autor,
                                       string anio,
                                       string numeroPaginas,
                                       string id,
                                       string barcode,
                                       string notas,
                                       Encuadernacion encuadernacion)
        {
            if (titulo.Length > 0 &&
                ConversorBarcode(barcode) > -1 &&
                short.TryParse(anio, out short anioShort) &&
                short.TryParse(numeroPaginas, out short numeroPaginasShort))
            {
                return new Libro(titulo, autor, anioShort, numeroPaginasShort, id, ConversorBarcode(barcode), notas, encuadernacion);
            }
            return null;
        }

    }
}
