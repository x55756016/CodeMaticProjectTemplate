
(function () {
    "use strict";
    var app = angular.module('HR.services', []);

    var services = ['users'
      	        	, 'tm_pm_company'
 		        	, 'tm_pm_department'
 		        	, 'tm_pm_dotask'
 		        	, 'tm_pm_itemreport'
 		        	, 'tm_pm_post'
 		        	, 'tm_pm_project'
 		        	, 'tm_pm_task'
 		        	, 'tm_pm_user'
    ];// the services without customized actions
    function addService(name, actions) {
        app.factory(name + 'Services', ['$resource', function ($resource) {
            return $resource('/api/' + name + '/:id', null, actions);
        }]);
    }
    angular.forEach(services, function (name) {
        addService(name, null);
    });
    //addService('login_register', { login: { method: 'POST', url: '/api/authenticate' } });
})();