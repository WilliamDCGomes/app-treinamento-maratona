import 'package:flutter/material.dart';
import 'package:flutter_project/2-app/views/pages/registerPage.dart';
import 'package:get/get.dart';

class LoginController extends GetxController {
  late TextEditingController loginInput;
  late TextEditingController passwordInput;
  late RxBool passwordFieldEnabled;

  LoginController(){
    passwordFieldEnabled = true.obs;
    loginInput = TextEditingController();
    passwordInput = TextEditingController();
  }

  accessButtonPressed(){

  }

  registerButtonPressed(){
    Get.to(() => RegisterPage());
  }

  forgetPasswordPressed(){

  }
}