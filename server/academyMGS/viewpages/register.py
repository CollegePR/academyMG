from academyMGS.models import *
import json
from django.http import HttpResponse
from django.views.decorators.csrf import csrf_exempt
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

