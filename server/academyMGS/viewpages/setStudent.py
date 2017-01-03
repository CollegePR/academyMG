from academyMGS.models import *
import json
from django.http import HttpResponse

def setStudent(request):
    data = [{'status': False}, {'flag', False}]
    id = ""
    name = ""
    sex = ""
    phone_num = ""
    address = ""
    school_name = ""
    grade = ""
    school_class = ""

    if request.method == "POST":
        id = request.POST['id']
        name = request.POST['name']
        sex = request.POST['sex']
        phone_num = request.POST['phone_num']
        address = request.POST['address']
        school_name = request.POST['school_name']
    else:
        return HttpResponse(json.dumps(data), content_type='application/json')

    st = Student(id=id, name=name, sex=sex, phone_num=phone_num, address=address, school_name=school_name,
                 school_class=school_class)
    st.save()
    data = [{'status': True}, {'flag': True}]
    return HttpResponse(json.dumps(data), content_type='application/json')
