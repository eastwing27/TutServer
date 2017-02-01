var myApp=angular.module('myApp');
myApp.controller('QuestionController', function($scope) {
     
    $scope.question={
        text: 'Какой js-фреймворк лучше использовать?',
        author: 'Иван Иванов',
        date: '20/10/2013',
        answers: 
        [{
            text: 'AngularJS!',
            author: 'Вова Сидоров',
            date: '20/10/2013',
            rate:2
        },{
            text: 'React',
            author: 'Олег Кузнецов',
            date: '20/10/2013',
            rate:-6
        },{
            text: 'Я бы использовал knockout',
            author: 'Неизвестный',
            date: '21/10/2013',
            rate:0
        },{
            text: 'Олег Кузнецов, React - это не фреймворк, еблан',
            author: 'Гершель Парасюк',
            date: '21/10/2013',
            rate:9
        }]
    };
     
    $scope.voteUp = function (answer){
        answer.rate++;
    };
    $scope.voteDown = function (answer){
        answer.rate--;
    };
    $scope.questColorClass= "questcolor";
    $scope.changeClass = function (e) 
    {
        $scope.questColorClass = e.type == "mouseover" ? "questselectedcolor" : "questcolor";
    }
});