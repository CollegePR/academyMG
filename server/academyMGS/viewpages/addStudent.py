from academyMGS.models import *
import json
from django.http import HttpResponse


def addStudent(request):
    data = [{'status': False}, {'flag': False}]
    requestId = ""
    name = ""
    sex = ""
    phone_num = ""
    address = ""
    school_name = ""
    grade = ""
    school_class = ""
    try:
        if request.method == "POST":
            requestId = request.POST.get('requestid')

            name = request.POST.get('name')

            sex = request.POST.get('sex')

            phone_num = request.POST.get('phone_num')

            address = request.POST.get('address')

            school_name = request.POST.get('school_name')

            school_class = request.POST.get('school_class')



        else:
            print("try문 else문진입")
            return HttpResponse(json.dumps(data), content_type='application/json')

        st = Student(id=requestId, name=name,
                     sex=sex,
                     phone_num=phone_num,
                     address=address,
                     school_name=school_name,
                     school_class=school_class
                     )
        st.save()
        data = [{'status': True}, {'flag': True}]
    except:
        print("예외문진입")
        return HttpResponse(json.dumps(data), content_type='application/json')

    return HttpResponse(json.dumps(data), content_type='application/json')
