<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_72713d7121d5d75a9e175ac0c9a0932a3045101443fe26ff312847429290c175 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_7c12a9abb4f5c40a7b414ae5c6b7eff2e901af242987fde6aafbd0e0c39837fa = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_7c12a9abb4f5c40a7b414ae5c6b7eff2e901af242987fde6aafbd0e0c39837fa->enter($__internal_7c12a9abb4f5c40a7b414ae5c6b7eff2e901af242987fde6aafbd0e0c39837fa_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_7c12a9abb4f5c40a7b414ae5c6b7eff2e901af242987fde6aafbd0e0c39837fa->leave($__internal_7c12a9abb4f5c40a7b414ae5c6b7eff2e901af242987fde6aafbd0e0c39837fa_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_0cca51c5de9b6cf548c3a0ff602b407be2967fb03b32e92e4ba1eae6f6623077 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_0cca51c5de9b6cf548c3a0ff602b407be2967fb03b32e92e4ba1eae6f6623077->enter($__internal_0cca51c5de9b6cf548c3a0ff602b407be2967fb03b32e92e4ba1eae6f6623077_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_0cca51c5de9b6cf548c3a0ff602b407be2967fb03b32e92e4ba1eae6f6623077->leave($__internal_0cca51c5de9b6cf548c3a0ff602b407be2967fb03b32e92e4ba1eae6f6623077_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_4a7553eee6ddca472b67b37f88692fec35e07f670def3f298db5d4e42f55ce27 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_4a7553eee6ddca472b67b37f88692fec35e07f670def3f298db5d4e42f55ce27->enter($__internal_4a7553eee6ddca472b67b37f88692fec35e07f670def3f298db5d4e42f55ce27_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_4a7553eee6ddca472b67b37f88692fec35e07f670def3f298db5d4e42f55ce27->leave($__internal_4a7553eee6ddca472b67b37f88692fec35e07f670def3f298db5d4e42f55ce27_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_8a0ed5f8f36eb4517baa354410aa869765c5d45619d6350975733cb51b6a254a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_8a0ed5f8f36eb4517baa354410aa869765c5d45619d6350975733cb51b6a254a->enter($__internal_8a0ed5f8f36eb4517baa354410aa869765c5d45619d6350975733cb51b6a254a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_8a0ed5f8f36eb4517baa354410aa869765c5d45619d6350975733cb51b6a254a->leave($__internal_8a0ed5f8f36eb4517baa354410aa869765c5d45619d6350975733cb51b6a254a_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  73 => 13,  67 => 12,  56 => 7,  53 => 6,  47 => 5,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
";
    }
}
