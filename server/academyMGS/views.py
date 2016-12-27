from django.shortcuts import render
from .models import *
import json
from django.http import HttpResponse
from django.views.decorators.csrf import csrf_exempt

@csrf_exempt
def idCheck(request):
    data = [{'status':False}]
    requestId = ""
    if request.method == 'GET':
        id = request.GET['id']
    else:
        return HttpResponse(json.dumps(data), content_type='application/json')

    data = [{'status':True},{'flag': (Teacher.objects.all().filter(id=requestId) is None)and(True)or(False)}, ]
    return HttpResponse(json.dumps(data), content_type='application/json')
@csrf_exempt
def index(request):
    return HttpResponse("don't access", content_type='application/json')
