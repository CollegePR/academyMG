from academyMGS.models import *
import json
from django.http import HttpResponse

def search(request):


    return HttpResponse("don't access", content_type='application/json')

#원생재갱신 : 아이디 넘겨받으면 그 아이디에 있는 학생정보를 입력한 값으로 수정하는 기능