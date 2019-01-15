<?php

/* @WebProfiler/Collector/exception.html.twig */
class __TwigTemplate_f32ad73c9bc804e7d7685ce925e27ce9c7daa98efc0b9a8c89227d7076a75563 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/exception.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
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
        $__internal_cc119b45eb380d84ec097e759b4dfa02e6c2ae7189665a95be14b3e5eac3ea9e = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_cc119b45eb380d84ec097e759b4dfa02e6c2ae7189665a95be14b3e5eac3ea9e->enter($__internal_cc119b45eb380d84ec097e759b4dfa02e6c2ae7189665a95be14b3e5eac3ea9e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $__internal_a0856578b345afdda2fcc94081f25d12bcb121fd0c7b9cc3b72a9f7eff116e60 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_a0856578b345afdda2fcc94081f25d12bcb121fd0c7b9cc3b72a9f7eff116e60->enter($__internal_a0856578b345afdda2fcc94081f25d12bcb121fd0c7b9cc3b72a9f7eff116e60_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_cc119b45eb380d84ec097e759b4dfa02e6c2ae7189665a95be14b3e5eac3ea9e->leave($__internal_cc119b45eb380d84ec097e759b4dfa02e6c2ae7189665a95be14b3e5eac3ea9e_prof);

        
        $__internal_a0856578b345afdda2fcc94081f25d12bcb121fd0c7b9cc3b72a9f7eff116e60->leave($__internal_a0856578b345afdda2fcc94081f25d12bcb121fd0c7b9cc3b72a9f7eff116e60_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_92a21cc5b36b5d9e1ee558252ece60f9f0fd34e2c241acc21dc32a8868752637 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_92a21cc5b36b5d9e1ee558252ece60f9f0fd34e2c241acc21dc32a8868752637->enter($__internal_92a21cc5b36b5d9e1ee558252ece60f9f0fd34e2c241acc21dc32a8868752637_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_c18fb88c0766919a6a596566c6b5c514ef03a10948cf55fe2188587af54b218a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_c18fb88c0766919a6a596566c6b5c514ef03a10948cf55fe2188587af54b218a->enter($__internal_c18fb88c0766919a6a596566c6b5c514ef03a10948cf55fe2188587af54b218a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    ";
        if ($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 5
            echo "        <style>
            ";
            // line 6
            echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception_css", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
            echo "
        </style>
    ";
        }
        // line 9
        echo "    ";
        $this->displayParentBlock("head", $context, $blocks);
        echo "
";
        
        $__internal_c18fb88c0766919a6a596566c6b5c514ef03a10948cf55fe2188587af54b218a->leave($__internal_c18fb88c0766919a6a596566c6b5c514ef03a10948cf55fe2188587af54b218a_prof);

        
        $__internal_92a21cc5b36b5d9e1ee558252ece60f9f0fd34e2c241acc21dc32a8868752637->leave($__internal_92a21cc5b36b5d9e1ee558252ece60f9f0fd34e2c241acc21dc32a8868752637_prof);

    }

    // line 12
    public function block_menu($context, array $blocks = array())
    {
        $__internal_2bae7db52ac079f1381d552d1c7f63b768876f89f4fd8f84ad31b8627ca43000 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_2bae7db52ac079f1381d552d1c7f63b768876f89f4fd8f84ad31b8627ca43000->enter($__internal_2bae7db52ac079f1381d552d1c7f63b768876f89f4fd8f84ad31b8627ca43000_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_02fc12ca605fce68d400a0c79b0a4b703c8eabeef53a1136ca235a886119ef86 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_02fc12ca605fce68d400a0c79b0a4b703c8eabeef53a1136ca235a886119ef86->enter($__internal_02fc12ca605fce68d400a0c79b0a4b703c8eabeef53a1136ca235a886119ef86_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 13
        echo "    <span class=\"label ";
        echo (($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) ? ("label-status-error") : ("disabled"));
        echo "\">
        <span class=\"icon\">";
        // line 14
        echo twig_include($this->env, $context, "@WebProfiler/Icon/exception.svg");
        echo "</span>
        <strong>Exception</strong>
        ";
        // line 16
        if ($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 17
            echo "            <span class=\"count\">
                <span>1</span>
            </span>
        ";
        }
        // line 21
        echo "    </span>
";
        
        $__internal_02fc12ca605fce68d400a0c79b0a4b703c8eabeef53a1136ca235a886119ef86->leave($__internal_02fc12ca605fce68d400a0c79b0a4b703c8eabeef53a1136ca235a886119ef86_prof);

        
        $__internal_2bae7db52ac079f1381d552d1c7f63b768876f89f4fd8f84ad31b8627ca43000->leave($__internal_2bae7db52ac079f1381d552d1c7f63b768876f89f4fd8f84ad31b8627ca43000_prof);

    }

    // line 24
    public function block_panel($context, array $blocks = array())
    {
        $__internal_c35f63226ece522f92438c4add80af13a4367261de8208d83a2f153253601442 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_c35f63226ece522f92438c4add80af13a4367261de8208d83a2f153253601442->enter($__internal_c35f63226ece522f92438c4add80af13a4367261de8208d83a2f153253601442_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_b6925d1517435934a4d51fad9b4c47b6ef8ba265fdbf8f3c771eab99c68b08e9 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_b6925d1517435934a4d51fad9b4c47b6ef8ba265fdbf8f3c771eab99c68b08e9->enter($__internal_b6925d1517435934a4d51fad9b4c47b6ef8ba265fdbf8f3c771eab99c68b08e9_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 25
        echo "    <h2>Exceptions</h2>

    ";
        // line 27
        if ( !$this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 28
            echo "        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    ";
        } else {
            // line 32
            echo "        <div class=\"sf-reset\">
            ";
            // line 33
            echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
            echo "
        </div>
    ";
        }
        
        $__internal_b6925d1517435934a4d51fad9b4c47b6ef8ba265fdbf8f3c771eab99c68b08e9->leave($__internal_b6925d1517435934a4d51fad9b4c47b6ef8ba265fdbf8f3c771eab99c68b08e9_prof);

        
        $__internal_c35f63226ece522f92438c4add80af13a4367261de8208d83a2f153253601442->leave($__internal_c35f63226ece522f92438c4add80af13a4367261de8208d83a2f153253601442_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/exception.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  138 => 33,  135 => 32,  129 => 28,  127 => 27,  123 => 25,  114 => 24,  103 => 21,  97 => 17,  95 => 16,  90 => 14,  85 => 13,  76 => 12,  63 => 9,  57 => 6,  54 => 5,  51 => 4,  42 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block head %}
    {% if collector.hasexception %}
        <style>
            {{ render(path('_profiler_exception_css', { token: token })) }}
        </style>
    {% endif %}
    {{ parent() }}
{% endblock %}

{% block menu %}
    <span class=\"label {{ collector.hasexception ? 'label-status-error' : 'disabled' }}\">
        <span class=\"icon\">{{ include('@WebProfiler/Icon/exception.svg') }}</span>
        <strong>Exception</strong>
        {% if collector.hasexception %}
            <span class=\"count\">
                <span>1</span>
            </span>
        {% endif %}
    </span>
{% endblock %}

{% block panel %}
    <h2>Exceptions</h2>

    {% if not collector.hasexception %}
        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    {% else %}
        <div class=\"sf-reset\">
            {{ render(path('_profiler_exception', { token: token })) }}
        </div>
    {% endif %}
{% endblock %}
", "@WebProfiler/Collector/exception.html.twig", "D:\\PHP Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\exception.html.twig");
    }
}
