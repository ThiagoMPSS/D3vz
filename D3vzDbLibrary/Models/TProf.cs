using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Tracing;
using System.Text.RegularExpressions;

namespace D3vzDbLibrary {
    public partial class TProf {
        public TProf() {
            TAulas = new HashSet<TAula>();
        }

        public static (bool[]? dias, bool[]? horarios) ConverterHorariosDias(string? horarios = null, string? dias = null) {
            bool[]? diasBool = null;
            if (dias != null) {
                diasBool = new Regex("([01])").Split(dias).Where(e => !string.IsNullOrEmpty(e)).Select(e => e != "0").ToArray();
                if (diasBool.Length != 7)
                    throw new Exception("Dias em formato inválido.");
            }

            bool[]? horariosBool = null;
            if (horarios != null) {
                horariosBool = new Regex("([01])").Split(horarios).Where(e => !string.IsNullOrEmpty(e)).Select(e => e != "0").ToArray();
                if (horariosBool.Length != 24)
                    throw new Exception("Horários em formato inválido.");
            }
            return (diasBool, horariosBool);
        }

        public long TUserIdUser { get; set; } = 0;
        [NotMapped]
        public bool[] Dias = new bool[6];
        [NotMapped]
        public bool[] Horarios = new bool[23];

        public string DiasString {
            get {
                var value = "";
                foreach (var d in Dias) {
                    value += d ? 1 : 0;
                }
                return value;
            }
            set {
                try {
                    Dias = ConverterHorariosDias(dias: value).dias!;
                } catch {}
            }
        }

        public string HorariosString {
            get {
                var value = "";
                foreach (var d in Horarios) {
                    value += d ? 1 : 0;
                }
                return value;
            }
            set {
                try {
                    Horarios = ConverterHorariosDias(value).horarios!;
                } catch { }
            }
        }

        public virtual TUser TUserIdUserNavigation { get; set; } = null!;
        public virtual ICollection<TAula> TAulas { get; set; }

    }
}
