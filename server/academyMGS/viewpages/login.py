from academyMGS.models import *
import json
from django.http import HttpResponse
from django.views.decorators.csrf import csrf_exempt


def login(request):
    data = [{'status': False,'flag': False}]
    id = ""
    password = ""
    try:
        if request.method == "POST":
            id = request.POST.get('id');
            password = request.POST.get('password');
        else:
            return HttpResponse(json.dumps(data), content_type='application/json')
        obj = Teacher.objects.get(id=id)
        if obj.password == password:
            data = [{'status': True}, {'flag': True}]
        else:
            data = [{'status': True}, {'flag': False}]

    except:
        return HttpResponse(json.dumps(data), content_type='application/json')
    return HttpResponse(json.dumps(data), content_type='application/json')
