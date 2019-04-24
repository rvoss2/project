using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing.Core.BLL
{
    /// <summary>
    /// Business class responsible viewing Package view models
    /// </summary>
    class PackageViewer
    {
        private readonly PackageDAO _packageDAO;

        public PackageViewer()
        {
            _packageDAO = new PackageDAO();
        }

        /// <summary>
        /// Returns specified package?
        /// </summary>
        public string GetStudent(long PackageID) //
        {
            return _packageDAO.GetPackage(PackageID);
        }
    }
}
