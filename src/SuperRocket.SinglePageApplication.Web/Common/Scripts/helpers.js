var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('SinglePageApplication');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);