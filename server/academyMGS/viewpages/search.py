from academyMGS.models import *
import json
from django.http import HttpResponse

def search(request):
    return HttpResponse("don't access", content_type='application/json')