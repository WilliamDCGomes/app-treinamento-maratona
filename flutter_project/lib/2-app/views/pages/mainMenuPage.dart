import 'package:flutter/material.dart';
import 'package:flutter_project/2-app/controllers/mainMenuController.dart';
import 'package:flutter_project/2-app/views/componentsWidgets/exerciseCardWidget.dart';
import 'package:flutter_project/2-app/views/componentsWidgets/menuOptionsWidget.dart';
import 'package:flutter_project/2-app/views/componentsWidgets/textWidget.dart';
import 'package:flutter_project/2-app/views/stylePages/appColors.dart';
import 'package:font_awesome_flutter/font_awesome_flutter.dart';
import 'package:get/get.dart';
import 'package:responsive_sizer/responsive_sizer.dart';

class MainMenuPage extends StatefulWidget {
  const MainMenuPage({Key? key}) : super(key: key);

  @override
  _MainMenuPageState createState() => _MainMenuPageState();
}

class _MainMenuPageState extends State<MainMenuPage> {
  late MainMenuController controller;

  @override
  Widget build(BuildContext context) {
    controller = Get.put(MainMenuController());

    return SafeArea(
      child: Material(
        child: GestureDetector(
          onTap: () {
            FocusScope.of(context).requestFocus(FocusNode());
          },
          child: Container(
            color: AppColors().backgroundStandardColor,
            child: Scaffold(
              backgroundColor: AppColors().transparentColor,
              body: Padding(
                padding: EdgeInsets.fromLTRB(2.h, 2.h, 2.h, 1.h),
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.stretch,
                  children: [
                    SizedBox(
                      height: 8.h,
                      child: Row(
                        mainAxisAlignment: MainAxisAlignment.spaceBetween,
                        children: [
                          Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            children: [
                              TextWidget(
                                "Olá, ${controller.nameUser}",
                                textColor: AppColors().whiteColor,
                                fontSize: 17.sp,
                                textAlign: TextAlign.start,
                              ),
                              Obx(() => TextWidget(
                                  controller.welcomePhrase.value,
                                  textColor: AppColors().whiteColor,
                                  fontWeight: FontWeight.bold,
                                  fontSize: 21.sp,
                                  textAlign: TextAlign.start,
                                ),
                              ),
                            ],
                          ),
                          Container(
                            height: 8.h,
                            width: 8.h,
                            decoration: BoxDecoration(
                              borderRadius: BorderRadius.circular(4.h),
                              color: AppColors().grayColor,
                            ),
                            child: Obx(
                                () => controller.hasPicture.value ?
                                  Image.asset(
                                    ""
                                  ) :
                                  Center(
                                    child: TextWidget(
                                      controller.nameInitials,
                                      textColor: AppColors().backgroundStandardColor,
                                      fontWeight: FontWeight.bold,
                                      fontSize: 22.sp,
                                      textAlign: TextAlign.start,
                                    ),
                                  ),
                            ),
                          ),
                        ],
                      ),
                    ),
                    Padding(
                      padding: EdgeInsets.only(top: 2.h),
                      child: Container(
                        height: 82.h,
                        child: SingleChildScrollView(
                          child: Column(
                            crossAxisAlignment: CrossAxisAlignment.stretch,
                            children: [
                              Container(
                                height: 25.h,
                                width: 80.w,
                                decoration: BoxDecoration(
                                  borderRadius: BorderRadius.circular(2.5.h),
                                  gradient: LinearGradient(
                                    begin: Alignment.topLeft,
                                    end: Alignment.bottomRight,
                                    colors: controller.colors,
                                  ),
                                ),
                                child: Padding(
                                  padding: EdgeInsets.all(1.h),
                                  child: Column(
                                    crossAxisAlignment: CrossAxisAlignment.stretch,
                                    children: [
                                      TextWidget(
                                        "Último exercício feito",
                                        textColor: AppColors().whiteColor,
                                        fontWeight: FontWeight.bold,
                                        fontSize: 22.sp,
                                        textAlign: TextAlign.start,
                                      ),
                                    ],
                                  ),
                                ),
                              ),
                              Padding(
                                padding: EdgeInsets.only(top: 2.h),
                                child: Row(
                                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                                  children: [
                                    MenuOptionsWidget(
                                      text: "Exercícios",
                                      icon: Icon(
                                        Icons.code_off_sharp,
                                        color: AppColors().blackColor91Percent,
                                        size: 6.h,
                                      ),
                                    ),
                                    MenuOptionsWidget(
                                      text: "Recomendados",
                                      icon: Icon(
                                        Icons.recommend_rounded,
                                        color: AppColors().blackColor91Percent,
                                        size: 6.h,
                                      ),
                                    ),
                                    MenuOptionsWidget(
                                      text: "Favoritos",
                                      icon: Icon(
                                        Icons.favorite,
                                        color: AppColors().blackColor91Percent,
                                        size: 6.h,
                                      ),
                                    ),
                                  ],
                                ),
                              ),
                              Padding(
                                padding: EdgeInsets.only(top: 2.h),
                                child: Row(
                                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                                  children: [
                                    MenuOptionsWidget(
                                      text: "Resolvidos",
                                      icon: Icon(
                                        Icons.done,
                                        color: AppColors().blackColor91Percent,
                                        size: 6.h,
                                      ),
                                    ),
                                    MenuOptionsWidget(
                                      text: "Adicionar",
                                      icon: Icon(
                                        Icons.add_circle,
                                        color: AppColors().blackColor91Percent,
                                        size: 6.h,
                                      ),
                                    ),
                                    MenuOptionsWidget(
                                      text: "Pontuação",
                                      icon: Icon(
                                        Icons.sports_score_sharp,
                                        color: AppColors().blackColor91Percent,
                                        size: 6.h,
                                      ),
                                    ),
                                  ],
                                ),
                              ),
                              Padding(
                                padding: EdgeInsets.only(top: 3.h),
                                child: TextWidget(
                                  "Exercícios marcados como favoritos",
                                  textColor: AppColors().whiteColor,
                                  fontWeight: FontWeight.bold,
                                  fontSize: 20.sp,
                                  textAlign: TextAlign.start,
                                ),
                              ),
                              Container(
                                height: 1,
                                color: AppColors().whiteColor,
                              ),
                              Padding(
                                padding: EdgeInsets.only(top: 1.5.h),
                                child: SingleChildScrollView(
                                    scrollDirection: Axis.horizontal,
                                    child: Row(
                                      children: [
                                        ExerciseCardWidget(title: "Exercício 1",),
                                        Padding(
                                          padding: EdgeInsets.only(left: 2.w),
                                          child: ExerciseCardWidget(title: "Exercício 2",),
                                        ),
                                        Padding(
                                          padding: EdgeInsets.only(left: 2.w),
                                          child: ExerciseCardWidget(title: "Exercício 3",),
                                        ),
                                        Padding(
                                          padding: EdgeInsets.only(left: 2.w),
                                          child: ExerciseCardWidget(title: "Exercício 4",),
                                        ),
                                      ],
                                    )
                                ),
                              ),
                              Padding(
                                padding: EdgeInsets.only(top: 3.h),
                                child: TextWidget(
                                  "Recomendados para você",
                                  textColor: AppColors().whiteColor,
                                  fontWeight: FontWeight.bold,
                                  fontSize: 20.sp,
                                  textAlign: TextAlign.start,
                                ),
                              ),
                              Container(
                                height: 1,
                                color: AppColors().whiteColor,
                              ),
                              Padding(
                                padding: EdgeInsets.only(top: 1.5.h),
                                child: SingleChildScrollView(
                                    scrollDirection: Axis.horizontal,
                                    child: Row(
                                      children: [
                                        ExerciseCardWidget(title: "Exercício 1",),
                                        Padding(
                                          padding: EdgeInsets.only(left: 2.w),
                                          child: ExerciseCardWidget(title: "Exercício 2",),
                                        ),
                                        Padding(
                                          padding: EdgeInsets.only(left: 2.w),
                                          child: ExerciseCardWidget(title: "Exercício 3",),
                                        ),
                                        Padding(
                                          padding: EdgeInsets.only(left: 2.w),
                                          child: ExerciseCardWidget(title: "Exercício 4",),
                                        ),
                                      ],
                                    )
                                ),
                              ),
                              Padding(
                                padding: EdgeInsets.only(top: 3.h),
                                child: TextWidget(
                                  "Últimos exercícios adicionados",
                                  textColor: AppColors().whiteColor,
                                  fontWeight: FontWeight.bold,
                                  fontSize: 20.sp,
                                  textAlign: TextAlign.start,
                                ),
                              ),
                              Container(
                                height: 1,
                                color: AppColors().whiteColor,
                              ),
                              Padding(
                                padding: EdgeInsets.only(top: 1.5.h),
                                child: SingleChildScrollView(
                                    scrollDirection: Axis.horizontal,
                                    child: Row(
                                      children: [
                                        ExerciseCardWidget(title: "Exercício 1",),
                                        Padding(
                                          padding: EdgeInsets.only(left: 2.w),
                                          child: ExerciseCardWidget(title: "Exercício 2",),
                                        ),
                                        Padding(
                                          padding: EdgeInsets.only(left: 2.w),
                                          child: ExerciseCardWidget(title: "Exercício 3",),
                                        ),
                                        Padding(
                                          padding: EdgeInsets.only(left: 2.w),
                                          child: ExerciseCardWidget(title: "Exercício 4",),
                                        ),
                                      ],
                                    )
                                ),
                              ),
                            ],
                          ),
                        ),
                      ),
                    ),
                  ],
                ),
              ),
            ),
          ),
        ),
      ),
    );
  }
}