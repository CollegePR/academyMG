from academyMGS.models import *
import json
from django.http import HttpResponse
from django.views.decorators.csrf import csrf_exempt


def accessList(request):
    data = {'flag': False,'data':[{},{}]}
    requestId = ""
    try:
        Teacher.objects.filter(status=1)
        data = [{'status': True, 'flag': (Teacher.objects.filter(id=requestId).exists()) and (True) or (False)}, ]
    except:
        return HttpResponse(json.dumps(data), content_type='application/json')

    return HttpResponse(json.dumps(data), content_type='application/json')
