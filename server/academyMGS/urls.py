from django.conf.urls import patterns, include, url
from .views import *
urlpatterns = (
    url(r'^$', index),
    url(r'^idcheck/', idCheck),
    url(r'^register/', register),
    url(r'^login/',login),
)
