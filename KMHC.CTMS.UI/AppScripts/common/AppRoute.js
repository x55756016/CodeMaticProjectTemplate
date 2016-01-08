
angular.module('userApp', [
        'ngRoute',
        'ngResource',
        'HR.services',
        'Utility',
        //'common',
        'navigation.controllers'
                	, 'tm_pm_company'
                	, 'tm_pm_department'
                	, 'tm_pm_dotask'
                	, 'tm_pm_itemreport'
                	, 'tm_pm_post'
                	, 'tm_pm_project'
                	, 'tm_pm_task'
                	, 'tm_pm_user'
]).
    config([
        '$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
            $routeProvider.when('/', {});
            $routeProvider.when('/tm_pm_company', { templateUrl: '/Views/List/tm_pm_company.html', controller: 'tm_pm_companyCtrl' });
            $routeProvider.when('/Addtm_pm_company', { templateUrl: '/Views/Info/tm_pm_company.html', controller: 'Addtm_pm_companyCtrl' });
            $routeProvider.when('/Edittm_pm_company', { templateUrl: '/Views/Info/tm_pm_company.html', controller: 'Addtm_pm_companyCtrl' });
            $routeProvider.when('/tm_pm_department', { templateUrl: '/Views/List/tm_pm_department.html', controller: 'tm_pm_departmentCtrl' });
            $routeProvider.when('/Addtm_pm_department', { templateUrl: '/Views/Info/tm_pm_department.html', controller: 'Addtm_pm_departmentCtrl' });
            $routeProvider.when('/Edittm_pm_department', { templateUrl: '/Views/Info/tm_pm_department.html', controller: 'Addtm_pm_departmentCtrl' });
            $routeProvider.when('/tm_pm_dotask', { templateUrl: '/Views/List/tm_pm_dotask.html', controller: 'tm_pm_dotaskCtrl' });
            $routeProvider.when('/Addtm_pm_dotask', { templateUrl: '/Views/Info/tm_pm_dotask.html', controller: 'Addtm_pm_dotaskCtrl' });
            $routeProvider.when('/Edittm_pm_dotask', { templateUrl: '/Views/Info/tm_pm_dotask.html', controller: 'Addtm_pm_dotaskCtrl' });
            $routeProvider.when('/tm_pm_itemreport', { templateUrl: '/Views/List/tm_pm_itemreport.html', controller: 'tm_pm_itemreportCtrl' });
            $routeProvider.when('/Addtm_pm_itemreport', { templateUrl: '/Views/Info/tm_pm_itemreport.html', controller: 'Addtm_pm_itemreportCtrl' });
            $routeProvider.when('/Edittm_pm_itemreport', { templateUrl: '/Views/Info/tm_pm_itemreport.html', controller: 'Addtm_pm_itemreportCtrl' });
            $routeProvider.when('/tm_pm_post', { templateUrl: '/Views/List/tm_pm_post.html', controller: 'tm_pm_postCtrl' });
            $routeProvider.when('/Addtm_pm_post', { templateUrl: '/Views/Info/tm_pm_post.html', controller: 'Addtm_pm_postCtrl' });
            $routeProvider.when('/Edittm_pm_post', { templateUrl: '/Views/Info/tm_pm_post.html', controller: 'Addtm_pm_postCtrl' });
            $routeProvider.when('/tm_pm_project', { templateUrl: '/Views/List/tm_pm_project.html', controller: 'tm_pm_projectCtrl' });
            $routeProvider.when('/Addtm_pm_project', { templateUrl: '/Views/Info/tm_pm_project.html', controller: 'Addtm_pm_projectCtrl' });
            $routeProvider.when('/Edittm_pm_project', { templateUrl: '/Views/Info/tm_pm_project.html', controller: 'Addtm_pm_projectCtrl' });
            $routeProvider.when('/tm_pm_task', { templateUrl: '/Views/List/tm_pm_task.html', controller: 'tm_pm_taskCtrl' });
            $routeProvider.when('/Addtm_pm_task', { templateUrl: '/Views/Info/tm_pm_task.html', controller: 'Addtm_pm_taskCtrl' });
            $routeProvider.when('/Edittm_pm_task', { templateUrl: '/Views/Info/tm_pm_task.html', controller: 'Addtm_pm_taskCtrl' });
            $routeProvider.when('/tm_pm_user', { templateUrl: '/Views/List/tm_pm_user.html', controller: 'tm_pm_userCtrl' });
            $routeProvider.when('/Addtm_pm_user', { templateUrl: '/Views/Info/tm_pm_user.html', controller: 'Addtm_pm_userCtrl' });
            $routeProvider.when('/Edittm_pm_user', { templateUrl: '/Views/Info/tm_pm_user.html', controller: 'Addtm_pm_userCtrl' });

            $routeProvider.otherwise({ redirectTo: '/' });
        }
    ]).controller('MyController', function ($scope, $http) {
        $scope.logout = function () {
            $http({
                method: 'POST',
                url: '/User/UserLogout'
            }).success(function (data) {
                alert(data.Msg);
                window.location = "/User/Login#/Login";
            }).error(function (data) {
                alert(data);
            });
        };
    });
