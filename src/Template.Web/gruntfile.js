/// <binding />
/*
This file in the main entry point for defining grunt tasks and using grunt plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkID=513275&clcid=0x409
*/
module.exports = function (grunt) {
    // Load grunt tasks automatically
    require('load-grunt-tasks')(grunt);

    // Time how long tasks take. Can help when optimizing build times
    require('time-grunt')(grunt);

    // configure plugins
    grunt.initConfig({
        clean: {
            wwwroot: ['wwwroot/lib', 'wwwroot/js']
        },
        bowercopy: {
            options: {
                runBower: true,
                destPrefix: 'wwwroot/lib'
            },
            libs: {
                files: {
                    angular: 'angular',
                    'angular-route': 'angular-route',
                    'angular-bootstrap': 'angular-bootstrap',
                    jquery: 'jquery',
                    bootstrap: 'bootstrap/dist/css'
                }
            }
        },
        concat: {
            options: {
                separator: ';'
            },
            scripts: {
                src: ['Scripts/{,*/}/*.js'],
                dest: 'wwwroot/js/app.js'
            }
        },
        jshint: {
            options: {
                jshintrc: 'Scripts/.jshintrc',
                reporter: require('jshint-stylish')
            },
            scripts: {
                src: [
                    'Gruntfile.js',
                    'Scripts/{,*/}*.js'
                ]
            },
        },
        watch: {
            scripts: {
                files: ['Scripts/{,*/}/*.js'],
                tasks: ['concat']
            }
        }
    });

    // define tasks
    grunt.registerTask('default', [
        'clean:wwwroot',
        'bowercopy:libs',
        'concat:scripts',
        'watch:scripts'
    ]);
};