﻿using Sbran.Domain.Enums;
using System;

namespace Sbran.Domain.Entities
{
    /// <summary>
    /// Выезд отчет
    /// </summary>
    public sealed class Report
    {
        public Report()
        {
            Id = Guid.NewGuid();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Основная часть
        /// </summary>
        public string? MainPart { get; set; }

        /// <summary>
        /// Выводы
        /// </summary>
        public string? Findings { get; set; }

        /// <summary>
        /// Предложения
        /// </summary>
        public string? Suggestion { get; set; }

        /// <summary>
        /// Заинтересованность иностранной стороны
        /// </summary>
        public string? ForeignInterest { get; set; }

        /// <summary>
        /// ТипОтчета
        /// </summary>
        public ReportType ReportType { get; set; }
    }
}
