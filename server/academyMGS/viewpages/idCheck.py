from academyMGS.models import *
import json
from django.http import HttpResponse
from django.views.decorators.csrf import csrf_exempt
def idCheck(request):
    print("here")

    data = [{'status':False},{'flag',False}]
    requestId = ""
    if request.method == 'GET':
        requestId = request.GET['id']
    else:
        return HttpResponse(json.dumps(data), content_type='application/json')

    data = [{'status':True ,'flag': (Teacher.objects.filter(id=requestId).exists())and(True)or(False)}, ]
    return HttpResponse(json.dumps(data), content_type='application/json')