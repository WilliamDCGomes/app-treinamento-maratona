import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter_project/2-app/controllers/loginController.dart';
import 'package:flutter_project/2-app/helpers/paths.dart';
import 'package:flutter_project/2-app/views/componentsWidgets/textFieldWidget.dart';
import 'package:flutter_project/2-app/views/componentsWidgets/textWidget.dart';
import 'package:flutter_project/2-app/views/stylePages/appColors.dart';
import 'package:get/get.dart';
import 'package:responsive_sizer/responsive_sizer.dart';

class LoginPage extends StatefulWidget {
  const LoginPage({Key? key}) : super(key: key);

  @override
  _LoginPageState createState() => _LoginPageState();
}

class _LoginPageState extends State<LoginPage> {
  late LoginController controller;

  @override
  Widget build(BuildContext context) {
    controller = Get.put(LoginController());
    return SafeArea(
      child: Material(
        child: Container(
          color: AppColors().backgroundStandardColor,
          child: Stack(
            children: [
              Row(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  Image.asset(
                    "${Paths().imagesPath}oie_transparent.png",
                    height: 25.h,
                    width: 80.w,
                  ),
                ],
              ),
              Scaffold(
                backgroundColor: AppColors().transparentColor,
                appBar: AppBar(
                  title: TextWidget(
                    "Login",
                    textColor: AppColors().whiteColor,
                  ),
                  backgroundColor: AppColors().backgroundStandardColor,
                ),
                body: Padding(
                  padding: EdgeInsets.only(top: 15.h),
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.stretch,
                    children: [
                      TextWidget(
                        "FAÇA O LOGIN",
                        textColor: AppColors().whiteColor,
                        fontWeight: FontWeight.bold,
                        fontSize: 25.sp,
                      ),
                      TextFieldWidget(
                        controller: controller.loginInput,
                        hintText: "Digite seu login",
                        textColor: AppColors().whiteColor,
                      ),
                    ],
                  ),
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }
}
