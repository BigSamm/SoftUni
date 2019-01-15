<?php

/* base.html.twig */
class __TwigTemplate_93e2499d03c6402ea1e3906495568257ed0120721f7f5badb0e11600e82927c5 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_dcb7251db766248803658bb2d10c61180d755610b98f2c2142d638fae743ed72 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_dcb7251db766248803658bb2d10c61180d755610b98f2c2142d638fae743ed72->enter($__internal_dcb7251db766248803658bb2d10c61180d755610b98f2c2142d638fae743ed72_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        $__internal_3689953302b64b004711aec9c63b8b3a060ace3e20fda77bcec6c21c64ef2de4 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_3689953302b64b004711aec9c63b8b3a060ace3e20fda77bcec6c21c64ef2de4->enter($__internal_3689953302b64b004711aec9c63b8b3a060ace3e20fda77bcec6c21c64ef2de4_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

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
        // line 19
        echo "    <link rel=\"icon\" type=\"image/x-icon\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("favicon.ico"), "html", null, true);
        echo "\"/>
</head>

<body id=\"";
        // line 22
        $this->displayBlock('body_id', $context, $blocks);
        echo "\">
";
        // line 23
        $this->displayBlock('body', $context, $blocks);
        // line 26
        echo "</body>
</html>
";
        
        $__internal_dcb7251db766248803658bb2d10c61180d755610b98f2c2142d638fae743ed72->leave($__internal_dcb7251db766248803658bb2d10c61180d755610b98f2c2142d638fae743ed72_prof);

        
        $__internal_3689953302b64b004711aec9c63b8b3a060ace3e20fda77bcec6c21c64ef2de4->leave($__internal_3689953302b64b004711aec9c63b8b3a060ace3e20fda77bcec6c21c64ef2de4_prof);

    }

    // line 11
    public function block_title($context, array $blocks = array())
    {
        $__internal_8d9f54c53de248749dbb9c625b2a1a72a161886222903f26ef5abe5737696ebf = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_8d9f54c53de248749dbb9c625b2a1a72a161886222903f26ef5abe5737696ebf->enter($__internal_8d9f54c53de248749dbb9c625b2a1a72a161886222903f26ef5abe5737696ebf_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_611d28a4edce18d552afb301397ec4ac4a253a8e8d3458788bdebeb52b590eae = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_611d28a4edce18d552afb301397ec4ac4a253a8e8d3458788bdebeb52b590eae->enter($__internal_611d28a4edce18d552afb301397ec4ac4a253a8e8d3458788bdebeb52b590eae_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "TODO List";
        
        $__internal_611d28a4edce18d552afb301397ec4ac4a253a8e8d3458788bdebeb52b590eae->leave($__internal_611d28a4edce18d552afb301397ec4ac4a253a8e8d3458788bdebeb52b590eae_prof);

        
        $__internal_8d9f54c53de248749dbb9c625b2a1a72a161886222903f26ef5abe5737696ebf->leave($__internal_8d9f54c53de248749dbb9c625b2a1a72a161886222903f26ef5abe5737696ebf_prof);

    }

    // line 12
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_7edbc243adaaa74a15ea0028e5f15732ca449150da5c575907e3cc4f6a64405e = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_7edbc243adaaa74a15ea0028e5f15732ca449150da5c575907e3cc4f6a64405e->enter($__internal_7edbc243adaaa74a15ea0028e5f15732ca449150da5c575907e3cc4f6a64405e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        $__internal_8c7a27a22df32f0beb0df1992f7287fc04ef9ef301fc80e7d36153e6bb1a43ca = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_8c7a27a22df32f0beb0df1992f7287fc04ef9ef301fc80e7d36153e6bb1a43ca->enter($__internal_8c7a27a22df32f0beb0df1992f7287fc04ef9ef301fc80e7d36153e6bb1a43ca_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 13
        echo "        ";
        // line 14
        echo "        ";
        // line 15
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/index-style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 16
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/create-style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 17
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/delete-style.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_8c7a27a22df32f0beb0df1992f7287fc04ef9ef301fc80e7d36153e6bb1a43ca->leave($__internal_8c7a27a22df32f0beb0df1992f7287fc04ef9ef301fc80e7d36153e6bb1a43ca_prof);

        
        $__internal_7edbc243adaaa74a15ea0028e5f15732ca449150da5c575907e3cc4f6a64405e->leave($__internal_7edbc243adaaa74a15ea0028e5f15732ca449150da5c575907e3cc4f6a64405e_prof);

    }

    // line 22
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_de37a9695816d83801c028a56edf62eb18c125e9285210fc05324366a09278b0 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_de37a9695816d83801c028a56edf62eb18c125e9285210fc05324366a09278b0->enter($__internal_de37a9695816d83801c028a56edf62eb18c125e9285210fc05324366a09278b0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        $__internal_192111005b85241904ddca1f649c3127a0331a5fea1a8191fb1bd23b0b0f490a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_192111005b85241904ddca1f649c3127a0331a5fea1a8191fb1bd23b0b0f490a->enter($__internal_192111005b85241904ddca1f649c3127a0331a5fea1a8191fb1bd23b0b0f490a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_192111005b85241904ddca1f649c3127a0331a5fea1a8191fb1bd23b0b0f490a->leave($__internal_192111005b85241904ddca1f649c3127a0331a5fea1a8191fb1bd23b0b0f490a_prof);

        
        $__internal_de37a9695816d83801c028a56edf62eb18c125e9285210fc05324366a09278b0->leave($__internal_de37a9695816d83801c028a56edf62eb18c125e9285210fc05324366a09278b0_prof);

    }

    // line 23
    public function block_body($context, array $blocks = array())
    {
        $__internal_a93a896c66c31e19417ab0c825412b12c0e3f097daec48d9f2451fc037128e16 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_a93a896c66c31e19417ab0c825412b12c0e3f097daec48d9f2451fc037128e16->enter($__internal_a93a896c66c31e19417ab0c825412b12c0e3f097daec48d9f2451fc037128e16_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_016d068faf60f04ef50b08652164d1693967a732027372508732f0ec6e4bccf1 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_016d068faf60f04ef50b08652164d1693967a732027372508732f0ec6e4bccf1->enter($__internal_016d068faf60f04ef50b08652164d1693967a732027372508732f0ec6e4bccf1_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 24
        echo "    ";
        $this->displayBlock('main', $context, $blocks);
        
        $__internal_016d068faf60f04ef50b08652164d1693967a732027372508732f0ec6e4bccf1->leave($__internal_016d068faf60f04ef50b08652164d1693967a732027372508732f0ec6e4bccf1_prof);

        
        $__internal_a93a896c66c31e19417ab0c825412b12c0e3f097daec48d9f2451fc037128e16->leave($__internal_a93a896c66c31e19417ab0c825412b12c0e3f097daec48d9f2451fc037128e16_prof);

    }

    public function block_main($context, array $blocks = array())
    {
        $__internal_1fb20badd25c9455588a0b5446655e967a1ac3201e6211d79af7d466480794d5 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_1fb20badd25c9455588a0b5446655e967a1ac3201e6211d79af7d466480794d5->enter($__internal_1fb20badd25c9455588a0b5446655e967a1ac3201e6211d79af7d466480794d5_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_ae20ac02626841505451c7691464bb1d755ed18ec3b99d70f805924a16e45ea3 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ae20ac02626841505451c7691464bb1d755ed18ec3b99d70f805924a16e45ea3->enter($__internal_ae20ac02626841505451c7691464bb1d755ed18ec3b99d70f805924a16e45ea3_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_ae20ac02626841505451c7691464bb1d755ed18ec3b99d70f805924a16e45ea3->leave($__internal_ae20ac02626841505451c7691464bb1d755ed18ec3b99d70f805924a16e45ea3_prof);

        
        $__internal_1fb20badd25c9455588a0b5446655e967a1ac3201e6211d79af7d466480794d5->leave($__internal_1fb20badd25c9455588a0b5446655e967a1ac3201e6211d79af7d466480794d5_prof);

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
        return array (  146 => 24,  137 => 23,  120 => 22,  108 => 17,  104 => 16,  99 => 15,  97 => 14,  95 => 13,  86 => 12,  68 => 11,  56 => 26,  54 => 23,  50 => 22,  43 => 19,  41 => 12,  37 => 11,  30 => 6,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{#
   This is the base template used as the application layout which contains the
   common elements and decorates all the other templates.
   See http://symfony.com/doc/current/book/templating.html#template-inheritance-and-layouts
#}
<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>{% block title %}TODO List{% endblock %}</title>
    {% block stylesheets %}
        {#<link rel=\"stylesheet\" href=\"{{ asset('css/reset-style.css') }}\">;#}
        {#<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\">#}
        <link rel=\"stylesheet\" href=\"{{ asset('css/index-style.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/create-style.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/delete-style.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">
{% block body %}
    {% block main %}{% endblock %}
{% endblock %}
</body>
</html>
", "base.html.twig", "D:\\PHP Skeleton\\app\\Resources\\views\\base.html.twig");
    }
}
