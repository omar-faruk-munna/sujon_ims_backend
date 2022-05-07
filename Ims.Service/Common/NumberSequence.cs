using Ims.Context;
using Ims.Logging;
using Ims.Repository.Common;
using System;
using System.Linq;
using System.Threading;

namespace Ims.Service.Common
{
    public class NumberSequence : INumberSequence
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogRepo _log;

        public NumberSequence(ApplicationDbContext context, ILogRepo log)
        {
            _context = context;
            this._log = log;
        }

        public string GetNumberSequence(string module)
        {
            string result = "";

            try
            {
                int counter = 0;

                Ims.Model.NumberSequence numberSequence = _context.NumberSequence
                    .Where(x => x.Module.Equals(module))
                    .FirstOrDefault();

                if (numberSequence == null)
                {
                    numberSequence = new Ims.Model.NumberSequence();
                    numberSequence.Module = module;
                    Interlocked.Increment(ref counter);
                    numberSequence.LastNumber = counter;
                    numberSequence.NumberSequenceName = module;
                    numberSequence.Prefix = module;

                    _context.Add(numberSequence);
                    _context.SaveChanges();
                }
                else
                {
                    counter = numberSequence.LastNumber;

                    Interlocked.Increment(ref counter);
                    numberSequence.LastNumber = counter;

                    _context.Update(numberSequence);
                    _context.SaveChanges();
                }

                result = $"{numberSequence.Prefix}#{counter.ToString().PadLeft(8, '0')}";
            }
            catch (Exception e)
            {
                _log.LogError(e.Message);
            }

            return result;
        }
    }
}
