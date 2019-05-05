using Abp.Web.Mvc.Views;

namespace PPG.Production.Web.Views
{
    public abstract class ProductionWebViewPageBase : ProductionWebViewPageBase<dynamic>
    {

    }

    public abstract class ProductionWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ProductionWebViewPageBase()
        {
            LocalizationSourceName = ProductionConsts.LocalizationSourceName;
        }
    }
}