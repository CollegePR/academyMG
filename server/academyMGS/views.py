from django.shortcuts import render
from .models import *
import json
from django.http import HttpResponse
from django.views.decorators.csrf import csrf_exempt

@csrf_exempt
def idCheck(request):
    data = [{'status':False},{'flag',False}]
    requestId = ""
    if request.method == 'GET':
        requestId = request.GET['id']
    else:
        return HttpResponse(json.dumps(data), content_type='application/json')
    Teacher.objects.get(id=requestId)
    data = [{'status':True},{'flag': (Teacher.objects.get(id=requestId) is None)and(True)or(False)}, ]
    return HttpResponse(json.dumps(data), content_type='application/json')
@csrf_exempt
def index(request):
    return HttpResponse("don't access", content_type='application/json')
@csrf_exempt
def register(request):
    data = [{'status':False},{'flag',False}]
    id=""
    password=""
    academy_class=""
    name=""
    if request.method == "POST":
        id=request.POST['id'];
        password=request.POST['password'];
        academy_class=request.POST['class'];
        name=request.POST['name'];
    else:
        return HttpResponse(json.dumps(data), content_type='application/json')
    teacher = Teacher(
        id=id,
        password=password,
        acdemy_class=academy_class,
        name=name,
    )
    teacher.save()
    data = [{'status': True},{'flag':True}]
    return HttpResponse(json.dumps(data), content_type='application/json')
@csrf_exempt
def login(request):
    data = [{'status':False},{'flag',False}]
    id = ""
    password = ""
    if request.method == "POST":
        id = request.POST['id'];
        password = request.POST['password'];
    else:
        return HttpResponse(json.dumps(data), content_type='application/json')
    obj = Teacher.objects.get(id=id)
    if obj.password == password :
        data = [{'status': True}, {'flag': True}]
    else :
        data = [{'status': True}, {'flag': False}]
    return HttpResponse(json.dumps(data), content_type='application/json')
