import 'package:flutter/material.dart';
import 'package:flutter_project/2-app/helpers/paths.dart';
import 'package:flutter_project/2-app/views/stylePages/appColors.dart';
import 'package:responsive_sizer/responsive_sizer.dart';
import 'textWidget.dart';

class ExerciseCardWidget extends StatelessWidget {
  final String title;
  final double? widthButton;
  final FontWeight? fontWeight;
  final Color? textColor;
  final List<Color>? colors;
  final Function()? onPressed;

  const ExerciseCardWidget(
      { Key? key,
        required this.title,
        this.widthButton,
        this.fontWeight,
        this.textColor,
        this.colors,
        this.onPressed,
      }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return GestureDetector(
      onTap: onPressed,
      child: Container(
        height: 22.h,
        width: 80.w,
        decoration: _getDecoration(),
        child: Stack(
          children: [
            Padding(
              padding: EdgeInsets.all(1.h),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.stretch,
                children: [
                  TextWidget(
                    title,
                    textColor: AppColors().whiteColor,
                    fontWeight: FontWeight.bold,
                    fontSize: 22.sp,
                    textAlign: TextAlign.start,
                  ),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }

  BoxDecoration _getDecoration(){
    return BoxDecoration(
      borderRadius: BorderRadius.circular(2.5.h),
      color: AppColors().redCardColor,
      image: DecorationImage(
          image: AssetImage(
            "${Paths().imagesPath}hardLevel.png",
          ),
          fit: BoxFit.cover,
          opacity: 0.6,
        ),
    );
    BoxDecoration(
      borderRadius: BorderRadius.circular(2.5.h),
      color: AppColors().orangeCardColor,
      image: DecorationImage(
          image: AssetImage(
            "${Paths().imagesPath}postIntermediateLevel.png",
          ),
          fit: BoxFit.cover,
          opacity: 0.5,
        ),
    );
    BoxDecoration(
      borderRadius: BorderRadius.circular(2.5.h),
      color: AppColors().purpleCardColor,
      image: DecorationImage(
          image: AssetImage(
            "${Paths().imagesPath}intermediateLevel.png",
          ),
          fit: BoxFit.cover,
          opacity: 0.4,
        ),
    );
    BoxDecoration(
      borderRadius: BorderRadius.circular(2.5.h),
      color: AppColors().blueCardColor,
      image: DecorationImage(
          image: AssetImage(
            "${Paths().imagesPath}postBeginnerLevel.png",
          ),
          fit: BoxFit.cover,
          opacity: 0.5,
        ),
    );
    BoxDecoration(
      borderRadius: BorderRadius.circular(2.5.h),
      color: AppColors().greenCardColor,
      image: DecorationImage(
          image: AssetImage(
            "${Paths().imagesPath}beginnerLevel.png",
          ),
          fit: BoxFit.cover,
          opacity: 0.3,
        ),
    );
  }
}