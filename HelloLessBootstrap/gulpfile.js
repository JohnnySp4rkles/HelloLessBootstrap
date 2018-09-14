/// <binding BeforeBuild='lessCleaner' />
/*
This file is the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. https://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require("gulp"),
    fs = require("fs"),
    less = require("gulp-less");

gulp.task("lessCleaner", function () {
    return gulp.src('Content/less/Site.less')
        .pipe(less())
        .pipe(gulp.dest('Content'));
});