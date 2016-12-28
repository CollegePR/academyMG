from django.conf.urls import patterns, include, url
from .views import *
urlpatterns = (
    url(r'^$', indexPage),
    url(r'^addstudent',  addStudentPage),
    url(r'^idcheck', idCheckPage),
    url(r'^login', loginPage),
    url(r'^register', registerPage),
    url(r'^search', searchPage),
    url(r'^setstudent', setStudentPage),
)