using System;

namespace curso {
    class NegocioException : Exception {
        public NegocioException(string msg) : base(msg) {
        }
    }
}
