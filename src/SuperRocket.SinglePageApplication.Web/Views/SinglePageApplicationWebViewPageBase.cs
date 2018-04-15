using Abp.Web.Mvc.Views;

namespace SuperRocket.SinglePageApplication.Web.Views
{
    public abstract class SinglePageApplicationWebViewPageBase : SinglePageApplicationWebViewPageBase<dynamic>
    {

    }

    public abstract class SinglePageApplicationWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SinglePageApplicationWebViewPageBase()
        {
            LocalizationSourceName = SinglePageApplicationConsts.LocalizationSourceName;
        }
    }
}