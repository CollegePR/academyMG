from academyMGS.models import *
import json
from django.http import HttpResponse
from django.views.decorators.csrf import csrf_exempt
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