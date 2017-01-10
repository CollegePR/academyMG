from academyMGS.models import *
import json
from django.http import HttpResponse
import datetime

def setStudent(request):
    data = {'flag': False}
    id = 0
    name = ""
    sex = True
    phone_num = ""
    address = ""
    school_name = ""
    grade = 0
    school_class = ""
    status_of_sign = 1


    try:
        if request.method == "POST":
            id = request.POST.get('id')
            name = request.POST.get('name')
            sex = request.POST.get('sex')
            phone_num = request.POST.get('phone_num')
            address = request.POST.get('address')
            school_name = request.POST.get('school_name')
            grade = request.POST.get('grade')
            school_class = request.POST.get('school_class')
            status_of_sign = request.POST.get('status_of_sign')
            date_of_admission = request.POST.get('date_of_admission')
            date_of_readdmission = request.POST.get('date_of_readdmission')
            date_of_exit = request.POST.get('date_of_exit')
            birthday = request.POST.get('birthday')
            if id is None:
                return HttpResponse(json.dumps(data), content_type='application/json')
        else:
            return HttpResponse(json.dumps(data), content_type='application/json')
        student = Student.objects.get(id=id)
        if not name is None:
            student.name = name
        if not sex is None:
            student.sex = sex
        if not phone_num is None:
            student.phone_num = phone_num
        if not address is None:
            student.address = address
        if not school_name is None:
            student.school_name = school_name
        if not grade is None:
            student.grade = grade
        if not school_class is None:
            student.school_class = school_class
        if not status_of_sign is None:
            student.status_of_sign = status_of_sign


        student.save()
        data = {'flag': True}

    except:
        return HttpResponse(json.dumps(data), content_type='application/json')

    return HttpResponse(json.dumps(data), content_type='application/json')