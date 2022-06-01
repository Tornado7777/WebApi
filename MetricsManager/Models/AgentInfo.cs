using System;

namespace MetricsManager.Models
{
    /// <summary>
    /// Агент
    /// </summary>
    public class AgentInfo
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int AgentId { get; set; }

        /// <summary>
        /// Url адрес сервиса
        /// </summary>
        public String AgentAddress { get; set; }
        /// <summary>
        /// Активность
        /// </summary>
        public bool Enable { get; set; }
    }
}
