using System;

namespace AppMapUnityXamarinForms.Services
{
    public class SalesSevice : ISalesSevice
    {
        readonly IDataSource _dataSource;

        public SalesSevice(IDataSource dataSource)
        {
            if (dataSource == null)
            {
                throw new ArgumentNullException(nameof(dataSource));
            }
            _dataSource = dataSource;
        }

        public string GetData(string url)
        {
            return _dataSource.GetUrlResult(url);
        }
    }
}
