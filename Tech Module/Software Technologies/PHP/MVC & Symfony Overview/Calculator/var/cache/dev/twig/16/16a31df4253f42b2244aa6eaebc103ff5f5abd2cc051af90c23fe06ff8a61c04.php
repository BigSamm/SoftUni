<?php

/* base.html.twig */
class __TwigTemplate_7a306b38dba7f072c178742572a3b93c9d377d5b09a8cc9acd03eb05b27795ee extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'header' => array($this, 'block_header'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
            'javascripts' => array($this, 'block_javascripts'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_aafe6fb401a68d9cb9bddca0b3daa61c501b1c8b382f998be58bc84343524c70 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_aafe6fb401a68d9cb9bddca0b3daa61c501b1c8b382f998be58bc84343524c70->enter($__internal_aafe6fb401a68d9cb9bddca0b3daa61c501b1c8b382f998be58bc84343524c70_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        // line 6
        echo "<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>";
        // line 11
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
    ";
        // line 12
        $this->displayBlock('stylesheets', $context, $blocks);
        // line 16
        echo "    <link rel=\"icon\" type=\"image/x-icon\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("favicon.ico"), "html", null, true);
        echo "\"/>
</head>

<body id=\"";
        // line 19
        $this->displayBlock('body_id', $context, $blocks);
        echo "\">

";
        // line 21
        $this->displayBlock('header', $context, $blocks);
        // line 39
        echo "
<div class=\"container body-container\">
    ";
        // line 41
        $this->displayBlock('body', $context, $blocks);
        // line 48
        echo "</div>


";
        // line 51
        $this->displayBlock('javascripts', $context, $blocks);
        // line 57
        echo "
</body>
</html>
";
        
        $__internal_aafe6fb401a68d9cb9bddca0b3daa61c501b1c8b382f998be58bc84343524c70->leave($__internal_aafe6fb401a68d9cb9bddca0b3daa61c501b1c8b382f998be58bc84343524c70_prof);

    }

    // line 11
    public function block_title($context, array $blocks = array())
    {
        $__internal_8e93dc245a54c3e29dc8c3c7c039c5125977abb49196f8a86e66d3d77d9dd343 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_8e93dc245a54c3e29dc8c3c7c039c5125977abb49196f8a86e66d3d77d9dd343->enter($__internal_8e93dc245a54c3e29dc8c3c7c039c5125977abb49196f8a86e66d3d77d9dd343_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "Calculator";
        
        $__internal_8e93dc245a54c3e29dc8c3c7c039c5125977abb49196f8a86e66d3d77d9dd343->leave($__internal_8e93dc245a54c3e29dc8c3c7c039c5125977abb49196f8a86e66d3d77d9dd343_prof);

    }

    // line 12
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_b62199c0b1056806a6e49be66b391cdbf6c4a96aa34cc431486fcb0729506952 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_b62199c0b1056806a6e49be66b391cdbf6c4a96aa34cc431486fcb0729506952->enter($__internal_b62199c0b1056806a6e49be66b391cdbf6c4a96aa34cc431486fcb0729506952_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 13
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 14
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/bootstrap-datetimepicker.min.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_b62199c0b1056806a6e49be66b391cdbf6c4a96aa34cc431486fcb0729506952->leave($__internal_b62199c0b1056806a6e49be66b391cdbf6c4a96aa34cc431486fcb0729506952_prof);

    }

    // line 19
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_57825107337738b3d3fe6c0601ef981f110da3761a3c42e01b2fbbc70d43b630 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_57825107337738b3d3fe6c0601ef981f110da3761a3c42e01b2fbbc70d43b630->enter($__internal_57825107337738b3d3fe6c0601ef981f110da3761a3c42e01b2fbbc70d43b630_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_57825107337738b3d3fe6c0601ef981f110da3761a3c42e01b2fbbc70d43b630->leave($__internal_57825107337738b3d3fe6c0601ef981f110da3761a3c42e01b2fbbc70d43b630_prof);

    }

    // line 21
    public function block_header($context, array $blocks = array())
    {
        $__internal_09d04ae5310a603a5950bc9ef9cfa19d2551d52df9a6d89e18ecac7fc600dfd1 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_09d04ae5310a603a5950bc9ef9cfa19d2551d52df9a6d89e18ecac7fc600dfd1->enter($__internal_09d04ae5310a603a5950bc9ef9cfa19d2551d52df9a6d89e18ecac7fc600dfd1_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "header"));

        // line 22
        echo "    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"";
        // line 26
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("index");
        echo "\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
";
        
        $__internal_09d04ae5310a603a5950bc9ef9cfa19d2551d52df9a6d89e18ecac7fc600dfd1->leave($__internal_09d04ae5310a603a5950bc9ef9cfa19d2551d52df9a6d89e18ecac7fc600dfd1_prof);

    }

    // line 41
    public function block_body($context, array $blocks = array())
    {
        $__internal_b59cccd5b816105d04c68ff94ff127cf3b3d2e0f9fa346abb41719bbe4019577 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_b59cccd5b816105d04c68ff94ff127cf3b3d2e0f9fa346abb41719bbe4019577->enter($__internal_b59cccd5b816105d04c68ff94ff127cf3b3d2e0f9fa346abb41719bbe4019577_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 42
        echo "        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                ";
        // line 44
        $this->displayBlock('main', $context, $blocks);
        // line 45
        echo "            </div>
        </div>
    ";
        
        $__internal_b59cccd5b816105d04c68ff94ff127cf3b3d2e0f9fa346abb41719bbe4019577->leave($__internal_b59cccd5b816105d04c68ff94ff127cf3b3d2e0f9fa346abb41719bbe4019577_prof);

    }

    // line 44
    public function block_main($context, array $blocks = array())
    {
        $__internal_d5134fab0d897939d6639026b2588a9f9ffffeb5a00a00b2724c827cf9568982 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_d5134fab0d897939d6639026b2588a9f9ffffeb5a00a00b2724c827cf9568982->enter($__internal_d5134fab0d897939d6639026b2588a9f9ffffeb5a00a00b2724c827cf9568982_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_d5134fab0d897939d6639026b2588a9f9ffffeb5a00a00b2724c827cf9568982->leave($__internal_d5134fab0d897939d6639026b2588a9f9ffffeb5a00a00b2724c827cf9568982_prof);

    }

    // line 51
    public function block_javascripts($context, array $blocks = array())
    {
        $__internal_9b027d9c51c7da956bc68af50e76dd6675a6c61fdb101a6a05059ba391d1b4fa = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_9b027d9c51c7da956bc68af50e76dd6675a6c61fdb101a6a05059ba391d1b4fa->enter($__internal_9b027d9c51c7da956bc68af50e76dd6675a6c61fdb101a6a05059ba391d1b4fa_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "javascripts"));

        // line 52
        echo "    <script src=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/jquery-2.2.4.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 53
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/moment.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 54
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 55
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap-datetimepicker.min.js"), "html", null, true);
        echo "\"></script>
";
        
        $__internal_9b027d9c51c7da956bc68af50e76dd6675a6c61fdb101a6a05059ba391d1b4fa->leave($__internal_9b027d9c51c7da956bc68af50e76dd6675a6c61fdb101a6a05059ba391d1b4fa_prof);

    }

    public function getTemplateName()
    {
        return "base.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  205 => 55,  201 => 54,  197 => 53,  192 => 52,  186 => 51,  175 => 44,  166 => 45,  164 => 44,  160 => 42,  154 => 41,  134 => 26,  128 => 22,  122 => 21,  111 => 19,  102 => 14,  97 => 13,  91 => 12,  79 => 11,  69 => 57,  67 => 51,  62 => 48,  60 => 41,  56 => 39,  54 => 21,  49 => 19,  42 => 16,  40 => 12,  36 => 11,  29 => 6,);
    }

    public function getSource()
    {
        return "{#
   This is the base template used as the application layout which contains the
   common elements and decorates all the other templates.
   See http://symfony.com/doc/current/book/templating.html#template-inheritance-and-layouts
#}
<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>{% block title %}Calculator{% endblock %}</title>
    {% block stylesheets %}
        <link rel=\"stylesheet\" href=\"{{ asset('css/style.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/bootstrap-datetimepicker.min.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">

{% block header %}
    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"{{ path('index') }}\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
{% endblock %}

<div class=\"container body-container\">
    {% block body %}
        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                {% block main %}{% endblock %}
            </div>
        </div>
    {% endblock %}
</div>


{% block javascripts %}
    <script src=\"{{ asset('js/jquery-2.2.4.min.js') }}\"></script>
    <script src=\"{{ asset('js/moment.min.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap-datetimepicker.min.js') }}\"></script>
{% endblock %}

</body>
</html>
";
    }
}
