from academyMGS.models import *
import json
from django.http import HttpResponse
from django.views.decorators.csrf import csrf_exempt


def accessList(request):
    data = {'flag': False, 'data': []}
    requestId = ""
    try:
        objs = Teacher.objects.filter(status=1)
        for obj in objs:
            data.get("data").insert(
                {
                    "name": obj.name,
                    "id": obj.id,
                    "academyClass": obj.acdemy_class,
                }
            )
    except:
        return HttpResponse(json.dumps(data), content_type='application/json')

    return HttpResponse(json.dumps(data), content_type='application/json')
